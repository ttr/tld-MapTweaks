using Harmony;
using MelonLoader;
using UnityEngine;


namespace MapTweaks
{
    internal static class Patches
    {


        [HarmonyPatch(typeof(Panel_Map), "DoNearbyDetailsCheck")]
        public class MapTweaksDrawing
        {
            public static void Prefix(ref float radius)
            {
                radius *= Settings.options.rangeMulti;
                // MelonLogger.Log("range: " + radius);
            }
        }
        [HarmonyPatch(typeof(CharcoalItem))]
        [HarmonyPatch("Awake")]
        class PatchCharcoalMappingTime
        {
            static void Postfix(CharcoalItem __instance)
            {
                __instance.m_SurveyGameMinutes *= Settings.options.timeMulti;
                // MelonLogger.Log("time: " + __instance.m_SurveyGameMinutes);
            }
        }

    }

}