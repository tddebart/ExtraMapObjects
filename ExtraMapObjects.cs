using System.Reflection;
using BepInEx;
using HarmonyLib;
using MapsExt;
using MapsExt.MapObjects;
using UnboundLib;
using UnityEngine;

namespace ExtraMapObjects
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class ExtraMapObjects : BaseUnityPlugin
    {
        private const string ModId = "com.bosssloth.rounds.ExtraMapObjects";
        private const string ModName = "ExtraMapObjects";
        public const string Version = "1.0.0";

        public static ExtraMapObjects instance;

        private void Start()
        {
            var harmony = new Harmony(ModId);
            harmony.PatchAll();

            instance = this;
            
            var assembly = Assembly.GetCallingAssembly();
            this.ExecuteAfterSeconds(0.1f, () => {MapsExtended.instance.RegisterMapObjectsAction?.Invoke(assembly);});
        }
    }
}