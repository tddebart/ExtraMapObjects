using System.Reflection;
using BepInEx;
using ExtraMapObjects;
using MapsExt;
using MapsExt.Editor;
using MapsExt.Editor.MapObjects;
using MapsExt.MapObjects;
using UnboundLib;
using UnityEngine;

namespace ExtraMapObjectsEditor
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("com.bosssloth.rounds.ExtraMapObjects")]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class ExtraMapObjectsEditor : BaseUnityPlugin
    {
        private const string ModId = "com.bosssloth.rounds.ExtraMapObjectsEditor";
        private const string ModName = "ExtraMapObjectsEditor";
        public const string Version = ExtraMapObjects.ExtraMapObjects.Version;
        
        public void Start()
        {
            var assembly = Assembly.GetCallingAssembly();
            this.ExecuteAfterSeconds(0.1f, () => {MapsExtended.instance.RegisterMapObjectsAction?.Invoke(assembly);});
        }
    }
}