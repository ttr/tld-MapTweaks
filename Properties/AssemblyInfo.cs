using MelonLoader;
using System.Reflection;

//This is a C# comment. Comments have no impact on compilation.

[assembly: AssemblyTitle(MapTweaks.BuildInfo.ModName)]
[assembly: AssemblyCopyright($"Created by " + MapTweaks.BuildInfo.ModAuthor)]

[assembly: AssemblyVersion(MapTweaks.BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(MapTweaks.BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(MapTweaks.MapTweaks), MapTweaks.BuildInfo.ModName, MapTweaks.BuildInfo.ModVersion, MapTweaks.BuildInfo.ModAuthor)]

//This tells MelonLoader that the mod is only for The Long Dark.
[assembly: MelonGame("Hinterland", "TheLongDark")]