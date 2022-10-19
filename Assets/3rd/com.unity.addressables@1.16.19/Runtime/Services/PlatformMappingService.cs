using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UnityEngine.AddressableAssets
{
    /// <summary>
    /// Options for the Addressables build platform.
    /// </summary>
    public enum AddressablesPlatform
    {
        /// <summary>
        /// Use to indicate that the build platform is unknown.
        /// </summary>
        Unknown,
        /// <summary>
        /// Use to indicate that the build platform is Windows.
        /// </summary>
        Windows,
        /// <summary>
        /// Use to indicate that the build platform is OSX.
        /// </summary>
        OSX,
        /// <summary>
        /// Use to indicate that the build platform is Linux.
        /// </summary>
        Linux,
        /// <summary>
        /// Use to indicate that the build platform is PS4.
        /// </summary>
        PS4,
        /// <summary>
        /// Use to indicate that the build platform is PS4.
        /// </summary>
        Switch,
        /// <summary>
        /// Use to indicate that the build platform is XboxOne.
        /// </summary>
        XboxOne,
        /// <summary>
        /// Use to indicate that the build platform is WebGL.
        /// </summary>
        WebGL,
        /// <summary>
        /// Use to indicate that the build platform is iOS.
        /// </summary>
        iOS,
        /// <summary>
        /// Use to indicate that the build platform is Android.
        /// </summary>
        Android,
        /// <summary>
        /// Use to indicate that the build platform is WindowsUniversal.
        /// </summary>
        WindowsUniversal
    }

    /// <summary>
    /// Determines the Addressables build platform that should be used based on the target player build platform.
    /// </summary>
    public class PlatformMappingService
    {
#if UNITY_EDITOR
        // BuildTarget和AddressablesPlatform 关系
        private static readonly Dictionary<BuildTarget, AddressablesPlatform> s_BuildTargetMapping =
            new Dictionary<BuildTarget, AddressablesPlatform>()
        {
            {BuildTarget.XboxOne, AddressablesPlatform.XboxOne},
            {BuildTarget.Switch, AddressablesPlatform.Switch},
            {BuildTarget.PS4, AddressablesPlatform.PS4},
            {BuildTarget.iOS, AddressablesPlatform.iOS},
            {BuildTarget.Android, AddressablesPlatform.Android},
            {BuildTarget.WebGL, AddressablesPlatform.WebGL},
            {BuildTarget.StandaloneWindows, AddressablesPlatform.Windows},
            {BuildTarget.StandaloneWindows64, AddressablesPlatform.Windows},
            {BuildTarget.StandaloneOSX, AddressablesPlatform.OSX},
            {BuildTarget.StandaloneLinux64, AddressablesPlatform.Linux},
            {BuildTarget.WSAPlayer, AddressablesPlatform.WindowsUniversal},
#if !UNITY_2019_2_OR_NEWER
            {BuildTarget.StandaloneLinux, AddressablesPlatform.Linux},
            {BuildTarget.StandaloneLinuxUniversal, AddressablesPlatform.Linux}
#endif
        };
#endif
        // RuntimePlatform和AddressablesPlatform 关系
        private static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping =
            new Dictionary<RuntimePlatform, AddressablesPlatform>()
        {
            {RuntimePlatform.XboxOne, AddressablesPlatform.XboxOne},
            {RuntimePlatform.Switch, AddressablesPlatform.Switch},
            {RuntimePlatform.PS4, AddressablesPlatform.PS4},
            {RuntimePlatform.IPhonePlayer, AddressablesPlatform.iOS},
            {RuntimePlatform.Android, AddressablesPlatform.Android},
            {RuntimePlatform.WebGLPlayer, AddressablesPlatform.WebGL},
            {RuntimePlatform.WindowsPlayer, AddressablesPlatform.Windows},
            {RuntimePlatform.OSXPlayer, AddressablesPlatform.OSX},
            {RuntimePlatform.LinuxPlayer, AddressablesPlatform.Linux},
            {RuntimePlatform.WindowsEditor, AddressablesPlatform.Windows},
            {RuntimePlatform.OSXEditor, AddressablesPlatform.OSX},
            {RuntimePlatform.LinuxEditor, AddressablesPlatform.Linux},
            {RuntimePlatform.WSAPlayerARM, AddressablesPlatform.WindowsUniversal},
            {RuntimePlatform.WSAPlayerX64, AddressablesPlatform.WindowsUniversal},
            {RuntimePlatform.WSAPlayerX86, AddressablesPlatform.WindowsUniversal},
        };

#if UNITY_EDITOR
        internal static AddressablesPlatform GetAddressablesPlatformInternal(BuildTarget target)
        {
            if (s_BuildTargetMapping.ContainsKey(target))
                return s_BuildTargetMapping[target];
            return AddressablesPlatform.Unknown;
        }

#endif
        internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform)
        {
            if (s_RuntimeTargetMapping.ContainsKey(platform))
                return s_RuntimeTargetMapping[platform];
            return AddressablesPlatform.Unknown;
        }

        /// <summary>
        /// Retrieves the Addressables build platform that is being used.
        /// </summary>
        /// <returns>Returns the Addressables build platform that is being used.</returns>
        public static AddressablesPlatform GetPlatform()
        {
#if UNITY_EDITOR
            return GetAddressablesPlatformInternal(EditorUserBuildSettings.activeBuildTarget);
#else
            return GetAddressablesPlatformInternal(Application.platform);
#endif
        }
    }
}