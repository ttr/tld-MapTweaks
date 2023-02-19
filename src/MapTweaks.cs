using MelonLoader;
using UnityEngine;


namespace MapTweaks
{
    public static class BuildInfo
    {
        internal const string ModName = "MapTweaks";
        internal const string ModAuthor = "ttr, MikeyPdog, AlexTheRegent";
        internal const string ModVersion = "2.4.0";
    }
    internal class MapTweaks : MelonMod
	{
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
            LoggerInstance.Msg($"[{BuildInfo.ModName}] Version {BuildInfo.ModVersion} loaded!");
        }
    }
}


