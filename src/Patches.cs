using MelonLoader;
using HarmonyLib;
using Il2Cpp;

namespace MapTweaks
{
    internal static class Patches
    {


        [HarmonyPatch(typeof(Panel_Map), "DoNearbyDetailsCheck")]
        public class MapTweaksDrawing
        {
            public static void Prefix(ref float radius, ref bool shouldAllowVistaReveals)
            {
                radius *= Settings.options.rangeMulti;
                MelonLogger.Msg("range: " + radius + " " + shouldAllowVistaReveals);
            }
        }
        [HarmonyPatch(typeof(VistaLocation), "HasRequiredGearItem")]
        public class VistaLocation_HasRequiredGearItem
        {
            public static void Postfix(VistaLocation __instance, ref bool __result)
            {
                if (Settings.options.assumePolaroids && !__result)
                {
                    MelonLogger.Msg("Silent add: " + __instance.m_RequiredGearItem.name);
                    GameManager.GetPlayerManagerComponent().AddItemToPlayerInventory(__instance.m_RequiredGearItem);
                    __result = true;
                }
            }
        }
        [HarmonyPatch(typeof(Panel_Map), "RevealOnPolaroidDiscovery")]
        public class Panel_Map_RevealOnPolaroidDiscovery
        {
            public static bool Prefix()
            {
                if (Settings.options.assumePolaroids)
                { return false; }
                return true;
            }
        }

        [HarmonyPatch(typeof(CharcoalItem))]
        [HarmonyPatch("Awake")]
        class PatchCharcoalMappingTime
        {
            static void Postfix(CharcoalItem __instance)
            {
                __instance.m_SurveyGameMinutes *= Settings.options.timeMulti;
            }
        }
    }
}