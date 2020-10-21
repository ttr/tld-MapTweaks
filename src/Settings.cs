using ModSettings;

namespace MapTweaks
{
	internal class MapTweaksSettings : JsonModSettings
	{
		[Name("Drawing range mutiplier")]
		[Description("")]
		[Slider(0.1f, 5f)]
		public float rangeMulti = 1f;

		[Name("Drawing time mutiplier")]
		[Description("")]
		[Slider(0.1f, 5f)]
		public float timeMulti = 1f;

	}
	internal static class Settings
	{
		public static MapTweaksSettings options;
		public static void OnLoad()
		{
			options = new MapTweaksSettings();
			options.AddToModSettings("Map Tweaks Settings");
		}
	}
}