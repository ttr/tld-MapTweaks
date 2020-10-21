using MelonLoader;
using System.IO;
using UnityEngine;


namespace MapTweaks
{
	internal class MapTweaks : MelonMod
	{

		public override void OnApplicationStart()
		{
			Debug.Log($"[{InfoAttribute.Name}] Version {InfoAttribute.Version} loaded!");
			Settings.OnLoad();
		}
	}
}


			