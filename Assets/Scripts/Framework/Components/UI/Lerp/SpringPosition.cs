﻿using System;
using UnityEngine;

// 移动到特定位置
[DisallowMultipleComponent]
public class SpringPosition : MonoBehaviour {
    public Vector3 target = Vector3.zero;
    public float strength = 10f;
    public bool worldSpace = false;
    public bool ignoreTimeScale = false;

    public Action<GameObject> onFinished;

    public float stopThreshold = 0f;

    private void Update() {
        float delta = ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime;

        if (worldSpace) {
            if (this.stopThreshold == 0f) {
                this.stopThreshold = (target - transform.position).sqrMagnitude * 0.001f;
            }

            transform.position = SpringLerp(transform.position, target, strength, delta);

            if (this.stopThreshold >= (target - transform.position).sqrMagnitude) {
                transform.position = target;
                NotifyListeners();
                enabled = false;
            }
        }
        else {
            if (this.stopThreshold == 0f) {
                this.stopThreshold = (target - transform.localPosition).sqrMagnitude * 0.00001f;
            }

            transform.localPosition = SpringLerp(transform.localPosition, target, strength, delta);

            if (this.stopThreshold >= (target - transform.localPosition).sqrMagnitude) {
                transform.localPosition = target;
                NotifyListeners();
                enabled = false;
            }
        }
    }

    private void NotifyListeners() {
        onFinished?.Invoke(transform.gameObject);
    }

    [ContextMenu(nameof(Begin))]
    public SpringPosition Begin() {
        return Begin(gameObject, this.target, this.strength, onFinished);
    }

    public SpringPosition Begin(Vector3 pos) {
        return Begin(gameObject, pos, strength, onFinished);
    }

    public SpringPosition Begin(Vector3 pos, float strength, Action<GameObject> onFinished = null) {
        return Begin(gameObject, pos, strength, onFinished);
    }

    public static SpringPosition Begin(GameObject go, Vector3 pos, float strength, Action<GameObject> onFinished = null) {
        if (!go.TryGetComponent<SpringPosition>(out SpringPosition sp)) {
            sp = go.AddComponent<SpringPosition>();
        }

        sp.target = pos;
        sp.strength = strength;
        sp.onFinished = onFinished;

        if (!sp.enabled) {
            // reset
            sp.stopThreshold = 0f;
            sp.enabled = true;
        }

        return sp;
    }

#region 辅助方法 // 参考NGUI的NGUIMath.cs
    /// <summary>
    /// Calculate how much to interpolate by.
    /// </summary>
    public static float SpringLerp(float strength, float deltaTime) {
        if (deltaTime > 1f) deltaTime = 1f;
        int ms = Mathf.RoundToInt(deltaTime * 1000f);
        deltaTime = 0.001f * strength;
        float cumulative = 0f;
        for (int i = 0; i < ms; ++i) cumulative = Mathf.Lerp(cumulative, 1f, deltaTime);
        return cumulative;
    }

    /// <summary>
    /// Mathf.Lerp(from, to, Time.deltaTime * strength) is not framerate-independent. This function is.
    /// </summary>
    public static float SpringLerp(float from, float to, float strength, float deltaTime) {
        if (deltaTime > 1f) deltaTime = 1f;
        int ms = Mathf.RoundToInt(deltaTime * 1000f);
        deltaTime = 0.001f * strength;
        for (int i = 0; i < ms; ++i) {
            from = Mathf.Lerp(from, to, deltaTime);
        }

        return from;
    }

    /// <summary>
    /// Vector2.Lerp(from, to, Time.deltaTime * strength) is not framerate-independent. This function is.
    /// </summary>
    public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime) {
        return Vector2.Lerp(from, to, SpringLerp(strength, deltaTime));
    }

    /// <summary>
    /// Vector3.Lerp(from, to, Time.deltaTime * strength) is not framerate-independent. This function is.
    /// </summary>
    public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime) {
        return Vector3.Lerp(from, to, SpringLerp(strength, deltaTime));
    }
#endregion

}
