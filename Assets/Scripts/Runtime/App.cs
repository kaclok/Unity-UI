﻿using System;
using System.Threading;
using UnityEngine;

// 整个工程的入口
[DisallowMultipleComponent]
public class App : MonoBehaviour {
    public static App instance { get; private set; } = null;
    public bool HasExited { get; private set; } = false;

    #region 组件
    public NWSpeedTracer nwSpeedTracer;
    public TimeScaler timeScaler;
    public FrameScaler frameScaler;
    #endregion

#if UNITY_EDITOR
    public EAssetLoadType assetLoadType = EAssetLoadType.FromResources;

    private void OnValidate() {
        AssetService.loadType = assetLoadType;
    }
#endif

    private void OnDestroy() {
        instance = null;
    }

    private void Awake() {
        instance = this;

        // 未捕获异常
        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            Debug.LogError(e.ExceptionObject.ToString());
        };
        SynchronizationContext.SetSynchronizationContext(UnitySynchronizationContext.UnitySyncContext);
    }

    private void Start() {
        if (AssemblyProxy.TryInit()) {
            FBridge.HotfixInit();
        }
    }

    private void OnApplicationQuit()
    {
        // OnApplicationQuit在OnDestroy执行
        HasExited = true;
    }
}
