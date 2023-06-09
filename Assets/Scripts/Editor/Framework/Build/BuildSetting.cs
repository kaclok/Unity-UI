﻿using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildSetting {
    public static bool ChangeABVersion = true;
    public static readonly string ABOutputPath = $"{Application.dataPath}/{"../ABOutput"}";

    public static string AppVersionOutputPath {
        get {
            var platform = EditorUserBuildSettings.activeBuildTarget;
            string appVersion = GlobalSetting.AppVersion.ToString();
            return $"{ABOutputPath}/{platform.ToString()}/AppVersion_{appVersion}";
        }
    }

    public static string GetABOutputPath(uint abVersion) {
        string appVersion = AppVersionOutputPath;
        return $"{appVersion}/ABVersion_{abVersion.ToString()}";
    }

    public static string GetABOutputVersionPath(uint abVersion) {
        string appVersion = AppVersionOutputPath;
        return $"{appVersion}/ABVersion_{abVersion.ToString()}/ab.version.json";
    }

    // 基础ab, 也就是当前appVersion下打的第一个ab记录
    public static string BaseABOutputVersionPath {
        get {
            return GetABOutputVersionPath(1);
        }
    }

    public static string CurrentAppVersionPath {
        get {
            var platform = EditorUserBuildSettings.activeBuildTarget;
            return $"{ABOutputPath}/{platform.ToString()}/app.version.json";
        }
    }

    public static string CurrentABVersionPath {
        get {
            string appVersionPath = AppVersionOutputPath;
            return $"{appVersionPath}/ab.version.json";
        }
    }

    public static string ABBuildHistroyPath {
        get {
            string appVersionPath = AppVersionOutputPath;
            return $"{appVersionPath}/ab.histroy.json";
        }
    }

    public static BundleRecords CurrentABRecords {
        get {
            var manifest = new BundleRecords();
            var path = BuildSetting.CurrentABVersionPath;
            // 如果文件不存在,则版本号就是默认值0
            if (File.Exists(path)) {
                manifest.FromJson(path);
            }

            return manifest;
        }
    }

    public static BundleHistroy CurrentABHistroy {
        get {
            var manifest = new BundleHistroy();
            var path = BuildSetting.ABBuildHistroyPath;
            // 如果文件不存在,则版本号就是默认值0
            if (File.Exists(path)) {
                manifest.FromJson(path);
            }

            return manifest;
        }
    }
}
