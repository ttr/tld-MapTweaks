using MelonLoader;
using UnityEngine;


namespace MapTweaks
{
	internal class MapTweaks : MelonMod
	{

		public override void OnApplicationStart()
		{
			Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
			Settings.OnLoad();
		}
	}
}


