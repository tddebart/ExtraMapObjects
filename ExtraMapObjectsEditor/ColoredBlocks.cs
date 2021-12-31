using ExtraMapObjects;
using MapsExt.Editor;
using MapsExt.Editor.MapObjects;
using MapsExt.MapObjects;
using UnityEngine;

namespace ExtraMapObjectsEditor
{
    [EditorMapObjectSpec(typeof(MapObjects.Red), "Red", "Colored blocks")]
        public static class EditorRed
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.RedSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Red> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Red>(MapObjects.RedSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Red> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Red>(MapObjects.RedSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Green), "Green", "Colored blocks")]
        public static class EditorGreen
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.GreenSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Green> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Green>(MapObjects.GreenSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Green> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Green>(MapObjects.GreenSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Blue), "Blue", "Colored blocks")]
        public static class EditorBlue
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BlueSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Blue> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Blue>(MapObjects.BlueSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Blue> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Blue>(MapObjects.BlueSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Yellow), "Yellow", "Colored blocks")]
        public static class EditorYellow
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.YellowSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Yellow> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Yellow>(MapObjects.YellowSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Yellow> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Yellow>(MapObjects.YellowSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Purple), "Purple", "Colored blocks")]
        public static class EditorPurple
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.PurpleSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Purple> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Purple>(MapObjects.PurpleSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Purple> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Purple>(MapObjects.PurpleSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Orange), "Orange", "Colored blocks")]
        public static class EditorOrange
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.OrangeSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Orange> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Orange>(MapObjects.OrangeSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Orange> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Orange>(MapObjects.OrangeSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Brown), "Brown", "Colored blocks")]
        public static class EditorBrown
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BrownSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Brown> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Brown>(MapObjects.BrownSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Brown> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Brown>(MapObjects.BrownSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Pink), "Pink", "Colored blocks")]
        public static class EditorPink
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.PinkSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Pink> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Pink>(MapObjects.PinkSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Pink> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Pink>(MapObjects.PinkSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Cyan), "Cyan", "Colored blocks")]
        public static class EditorCyan
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.CyanSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Cyan> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Cyan>(MapObjects.CyanSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Cyan> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Cyan>(MapObjects.CyanSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.Black), "Black", "Colored blocks")]
        public static class EditorBlack
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BlackSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Black> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Black>(MapObjects.BlackSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Black> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Black>(MapObjects.BlackSpec.Deserialize);
        }
        
        [EditorMapObjectSpec(typeof(MapObjects.White), "White", "Colored blocks")]
        public static class EditorWhite
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.WhiteSpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.White> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.White>(MapObjects.WhiteSpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.White> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.White>(MapObjects.WhiteSpec.Deserialize);
        }
        
        //Grey
        [EditorMapObjectSpec(typeof(MapObjects.Grey), "Grey", "Colored blocks")]
        public static class EditorGrey
        {
            [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.GreySpec.Prefab;

            [EditorMapObjectSerializer]
            public static SerializerAction<MapObjects.Grey> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Grey>(MapObjects.GreySpec.Serialize);

            [EditorMapObjectDeserializer]
            public static DeserializerAction<MapObjects.Grey> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Grey>(MapObjects.GreySpec.Deserialize);
        }
}