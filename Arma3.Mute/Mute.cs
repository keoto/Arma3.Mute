using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAudio;

namespace SresgaminG.Arma3
{
    public static class Mute
    {
        private static MMDeviceCollection devCol;

        private static Int32 devIndex = -1;
        private static Int32 sesIndex = -1;

        public enum State
        {
            Muted = 0,
            Unmuted = 1
        }

        public static State MuteUnmute(string appName)
        {
            FindApplication(appName);

            if (devCol[devIndex].AudioSessionManager2.Sessions[sesIndex].GetSessionIdentifier.Contains(appName))
            {
                try
                {
                    devCol[devIndex].AudioSessionManager2.Sessions[sesIndex].SimpleAudioVolume.Mute = !devCol[devIndex].AudioSessionManager2.Sessions[sesIndex].SimpleAudioVolume.Mute;
                }
                catch (Exception ex)
                {

                }
            }

            return ToMuteState(devCol[devIndex].AudioSessionManager2.Sessions[sesIndex].SimpleAudioVolume.Mute);
        }

        public static State ToMuteState(bool value)
        {
            switch (value)
            {
                case true:
                    return State.Muted;
                default:
                    return State.Unmuted;
            }
        }

        public static List<string> GetListOfApplicationsWithAudio()
        {
            List<string> results = new List<string>();

            EDataFlow flow = new EDataFlow();
            MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();

            devCol = deviceEnum.EnumerateAudioEndPoints(flow, DEVICE_STATE.DEVICE_STATE_ACTIVE);

            for (int devIdx = 0; devIdx < devCol.Count; devIdx++)
            {
                for (int sesIdx = 0; sesIdx < devCol[devIdx].AudioSessionManager2.Sessions.Count; sesIdx++)
                {
                    results.Add(devCol[devIdx].AudioSessionManager2.Sessions[sesIdx].GetSessionIdentifier);
                }
            }

            return results;
        }

        public static bool IsMuted(string appName)
        {
            FindApplication(appName);

            if (devCol[devIndex].AudioSessionManager2.Sessions[sesIndex].GetSessionIdentifier.Contains(appName))
                return devCol[devIndex].AudioSessionManager2.Sessions[sesIndex].SimpleAudioVolume.Mute;

            throw new Exception("Application is not running or could not find");
        }

        private static void FindApplication(string appName)
        {
            EDataFlow flow = new EDataFlow();
            MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();

            devCol = deviceEnum.EnumerateAudioEndPoints(flow, DEVICE_STATE.DEVICE_STATE_ACTIVE);

            for (int devIdx = 0; devIdx < devCol.Count; devIdx++)
            {
                for (int sesIdx = 0; sesIdx < devCol[devIdx].AudioSessionManager2.Sessions.Count; sesIdx++)
                {
                    if (devCol[devIdx].AudioSessionManager2.Sessions[sesIdx].GetSessionIdentifier.Contains(appName))
                    {
                        devIndex = devIdx;
                        sesIndex = sesIdx;
                    }
                }
            }
        }
    }
}
