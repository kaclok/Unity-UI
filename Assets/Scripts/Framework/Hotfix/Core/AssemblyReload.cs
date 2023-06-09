﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

public interface IReload {
    void OnReload();
}

#if UNITY_EDITOR
public class AssemblyReload : IAssembly {
    private Assembly fixedAssembly = null;
    private Assembly hotReloadAssembly = null;

    private Type[] allTypes;

    private Dictionary<string, Type> fixedTypes = new Dictionary<string, Type>();
    private Dictionary<string, Type> hotReloadTypes = new Dictionary<string, Type>();
    
    public object CreateInstance(string typeNameIncludeNamespace) {
        // 不知道能否？
        // fixedAssembly.CreateInstance(typeNameIncludeNamespace) ?? hotReloadAssembly.CreateInstance(typeNameIncludeNamespace);
        object rlt = null;
        try {
            if (fixedTypes.TryGetValue(typeNameIncludeNamespace, out _)) {
                rlt = fixedAssembly.CreateInstance(typeNameIncludeNamespace);
            }
            else if (hotReloadTypes.TryGetValue(typeNameIncludeNamespace, out _)) {
                rlt = hotReloadAssembly.CreateInstance(typeNameIncludeNamespace);
            }

            return rlt;
        }
        catch {
            return null;
        }
    }

    public InstanceMethod CreateInstanceMethod(string typeNameIncludeNamespace, string methodName, ref object refInstance, int argCount) {
        if (fixedTypes.ContainsKey(typeNameIncludeNamespace)) {
            return new MonoInstanceMethod(fixedAssembly, typeNameIncludeNamespace, methodName, ref refInstance);
        }
        else if (hotReloadTypes.ContainsKey(typeNameIncludeNamespace)) {
            return new MonoInstanceMethod(hotReloadAssembly, typeNameIncludeNamespace, methodName, ref refInstance);
        }

        return null;
    }

    public StaticMethod CreateStaticMethod(string typeNameIncludeNamespace, string methodName, int argCount) {
        if (fixedTypes.ContainsKey(typeNameIncludeNamespace)) {
            return new MonoStaticMethod(fixedAssembly, typeNameIncludeNamespace, methodName);
        }
        else if (hotReloadTypes.ContainsKey(typeNameIncludeNamespace)) {
            return new MonoStaticMethod(hotReloadAssembly, typeNameIncludeNamespace, methodName);
        }

        return null;
    }

    public Type GetType(string typeNameWithNamespace) {
        if (fixedTypes.TryGetValue(typeNameWithNamespace, out var rlt)) {
            return rlt;
        }
        else if (hotReloadTypes.TryGetValue(typeNameWithNamespace, out rlt)) {
            return rlt;
        }

        return null;
    }
    
    public Type[] GetTypes() {
        return allTypes;
    }

    public void Clear() {
        fixedAssembly = null;
        hotReloadAssembly = null;
        allTypes = null;
    }
    
    public void Load() {
        LoadHotfixFixed();
        LoadHotReload();
    }

    public void LoadHotfixFixed() {
        string dllFullPath = Path.Combine(HotfixSettings.HotfixHotReloadRelativePath, HotfixSettings.HotfixFixedDLLNameWithExt);
        byte[] dllBytes = PathService.GetFileBytes(dllFullPath);

        try {
            // editor模式下，加载pdb for debug
            string pdbFullPath = Path.Combine(HotfixSettings.HotfixHotReloadRelativePath, HotfixSettings.HotfixFixedPdbNameWithExt);
            byte[] pdbBytes = PathService.GetFileBytes(pdbFullPath);
            fixedAssembly = Assembly.Load(dllBytes, pdbBytes);

            fixedTypes.Clear();
            foreach (var one in fixedAssembly.GetTypes()) {
                fixedTypes.Add(one.FullName, one);
            }
        }
        catch {
            Debug.LogError("请先编译生成 Fixed dll");
        }
    }
    
    public void LoadHotReload() {
        string[] files = Directory.GetFiles(HotfixSettings.HotfixHotReloadRelativePath, HotfixSettings.HotReloadDLLName);
        if (files.Length != 2) {
            throw new Exception("HotReload dll count != 2, but is: " + files.Length.ToString());
        }

        string nameWithoutExtension = Path.GetFileNameWithoutExtension(files[0]);
        string dllPath = Path.Combine(HotfixSettings.HotfixHotReloadRelativePath, nameWithoutExtension + ".dll");
        byte[] dllBytes = PathService.GetFileBytes(dllPath);

        try {
            string pdbPath = Path.Combine(HotfixSettings.HotfixHotReloadRelativePath, nameWithoutExtension + ".pdb");
            byte[] pdbBytes = PathService.GetFileBytes(pdbPath);
            hotReloadAssembly = Assembly.Load(dllBytes, pdbBytes);

            hotReloadTypes.Clear();
            foreach (var one in hotReloadAssembly.GetTypes()) {
                hotReloadTypes.Add(one.FullName, one);
            }

            List<Type> listType = new List<Type>();
            foreach (var kvp in fixedTypes) {
                listType.Add(kvp.Value);
            }

            foreach (var kvp in hotReloadTypes) {
                listType.Add(kvp.Value);
            }

            allTypes = listType.ToArray();
        }
        catch {
            Debug.LogError("请先编译生成 HotReload.dll");
        }
    }
}
#endif
