﻿using Logic.Hotfix.Fixed.Pbf;

namespace Logic.Hotfix.Fixed
{
    // 处理servertime
    public class ServerTimeService : SysBase<ServerTimeService>
    {
        public enum EEvents
        {
            OnTimeSync,
        }

        protected override void ProcessEvent(bool toRegister)
        {
            if (toRegister)
            {
                NWDelegateService.Add<SCTimeNtf>(0, (ushort)EMsgType.SctimeNtf, OnSctimeNtf, SCTimeNtf.Parser);
            }
            else
            {
                NWDelegateService.Remove<SCTimeNtf>((ushort)EMsgType.SctimeNtf, OnSctimeNtf);
            }
        }

        private void OnSctimeNtf(SCTimeNtf msg)
        {
            UnityEngine.Debug.LogError("res.Time: " + msg.Time);
        }
    }
}
