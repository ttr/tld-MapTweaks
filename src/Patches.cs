using HarmonyLib;
using MelonLoader;


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
        [HarmonyPatch(typeof(Panel_Map), "HasVistaLocationRequiredGearItem")]
        public class panel_map_HasVistaLocationRequiredGearItem
        {
            public static void Postfix(VistaLocation vistaLocation, bool __result)
            {
                if (Settings.options.assumePolaroids && !__result)
                {
                    MelonLogger.Msg(__result + " Would add: " + vistaLocation.m_RequiredGearItem.name);
                    GameManager.GetPlayerManagerComponent().AddItemToPlayerInventory(vistaLocation.m_RequiredGearItem);
                }
            }
        }
        [HarmonyPatch(typeof(Panel_Map), "RevealOnPolaroidDiscovery")]
        public class panel_map_RevealOnPolaroidDiscovery
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