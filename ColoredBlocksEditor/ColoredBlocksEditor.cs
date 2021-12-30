using System.Reflection;
using BepInEx;
using ColoredBlocks;
using MapsExt;
using MapsExt.Editor;
using MapsExt.Editor.MapObjects;
using MapsExt.MapObjects;
using UnboundLib;
using UnityEngine;

namespace ColoredBlocksEditor
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("com.bosssloth.rounds.ColoredBlocks")]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class ColoredBlocksEditor : BaseUnityPlugin
    {
        private const string ModId = "com.bosssloth.rounds.ColoredBlocksEditor";
        private const string ModName = "ColoredBlocksEditor";
        public const string Version = ColoredBlocks.ColoredBlocks.Version;
        
        public void Start()
        {
            var assembly = Assembly.GetCallingAssembly();
            this.ExecuteAfterSeconds(0.1f, () => {MapsExtended.instance.RegisterMapObjectsAction?.Invoke(assembly);});
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Red), "Red", "StickFight")]
        public static class EditorRed
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.RedSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Red> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Red>(MapObjects.RedSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Red> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Red>(MapObjects.RedSpec.Deserialize);
        }
    }
}