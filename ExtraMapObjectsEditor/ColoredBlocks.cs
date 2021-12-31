using ExtraMapObjects;
using MapsExt.Editor;
using MapsExt.Editor.MapObjects;
using MapsExt.MapObjects;
using UnityEngine;

namespace ExtraMapObjectsEditor
{
    
    #region Static objects
    
    #region Red
    [EditorMapObjectSpec(typeof(MapObjects.Red), "Red", "Colored blocks | Static")]
    public static class EditorRed
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.RedSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Red> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Red>(MapObjects.RedSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Red> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Red>(MapObjects.RedSpec.Deserialize);
    }
    
    #endregion
    
    #region Green
    
    [EditorMapObjectSpec(typeof(MapObjects.Green), "Green", "Colored blocks | Static")]
    public static class EditorGreen
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.GreenSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Green> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Green>(MapObjects.GreenSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Green> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Green>(MapObjects.GreenSpec.Deserialize);
    }
    
    #endregion
    
    #region Blue

    [EditorMapObjectSpec(typeof(MapObjects.Blue), "Blue", "Colored blocks | Static")]
    public static class EditorBlue
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BlueSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Blue> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Blue>(MapObjects.BlueSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Blue> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Blue>(MapObjects.BlueSpec.Deserialize);
    }
    
    #endregion
    
    #region Yellow
    
    [EditorMapObjectSpec(typeof(MapObjects.Yellow), "Yellow", "Colored blocks | Static")]
    public static class EditorYellow
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.YellowSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Yellow> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Yellow>(MapObjects.YellowSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Yellow> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Yellow>(MapObjects.YellowSpec.Deserialize);
    }
    
    #endregion
    
    #region Purple
    
    [EditorMapObjectSpec(typeof(MapObjects.Purple), "Purple", "Colored blocks | Static")]
    public static class EditorPurple
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.PurpleSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Purple> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Purple>(MapObjects.PurpleSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Purple> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Purple>(MapObjects.PurpleSpec.Deserialize);
    }
    
    #endregion
    
    #region Orange
    
    [EditorMapObjectSpec(typeof(MapObjects.Orange), "Orange", "Colored blocks | Static")]
    public static class EditorOrange
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.OrangeSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Orange> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Orange>(MapObjects.OrangeSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Orange> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Orange>(MapObjects.OrangeSpec.Deserialize);
    }
    
    #endregion
    
    #region Brown
    
    [EditorMapObjectSpec(typeof(MapObjects.Brown), "Brown", "Colored blocks | Static")]
    public static class EditorBrown
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BrownSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Brown> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Brown>(MapObjects.BrownSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Brown> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Brown>(MapObjects.BrownSpec.Deserialize);
    }
    
    #endregion
    
    #region Pink
    
    [EditorMapObjectSpec(typeof(MapObjects.Pink), "Pink", "Colored blocks | Static")]
    public static class EditorPink
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.PinkSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Pink> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Pink>(MapObjects.PinkSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Pink> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Pink>(MapObjects.PinkSpec.Deserialize);
    }
    
    #endregion
    
    #region Cyan
    
    [EditorMapObjectSpec(typeof(MapObjects.Cyan), "Cyan", "Colored blocks | Static")]
    public static class EditorCyan
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.CyanSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Cyan> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Cyan>(MapObjects.CyanSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Cyan> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Cyan>(MapObjects.CyanSpec.Deserialize);
    }
    
    #endregion

    #region Black

    [EditorMapObjectSpec(typeof(MapObjects.Black), "Black", "Colored blocks | Static")]
    public static class EditorBlack
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BlackSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Black> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Black>(MapObjects.BlackSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Black> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Black>(MapObjects.BlackSpec.Deserialize);
    }
    
    #endregion
    
    #region White
    
    [EditorMapObjectSpec(typeof(MapObjects.White), "White", "Colored blocks | Static")]
    public static class EditorWhite
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.WhiteSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.White> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.White>(MapObjects.WhiteSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.White> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.White>(MapObjects.WhiteSpec.Deserialize);
    }
    
    #endregion
    
    #region Grey
    
    [EditorMapObjectSpec(typeof(MapObjects.Grey), "Grey", "Colored blocks | Static")]
    public static class EditorGrey
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.GreySpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Grey> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Grey>(MapObjects.GreySpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Grey> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Grey>(MapObjects.GreySpec.Deserialize);
    }
    
    #endregion

    #endregion
    
    #region Dynamic objects
    
    #region RedPhys
    [EditorMapObjectSpec(typeof(MapObjects.RedPhys), "Red", "Colored blocks | Dynamic")]
    public static class EditorRedPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.RedPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.RedPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.RedPhys>(MapObjects.RedPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.RedPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.RedPhys>(MapObjects.RedPhysSpec.Deserialize);
    }
    
    #endregion
    
    #region GreenPhys
    
    [EditorMapObjectSpec(typeof(MapObjects.GreenPhys), "Green", "Colored blocks | Dynamic")]
    public static class EditorGreenPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.GreenPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.GreenPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.GreenPhys>(MapObjects.GreenPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.GreenPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.GreenPhys>(MapObjects.GreenPhysSpec.Deserialize);
    }
    
    #endregion
    
    #region BluePhys
    
    [EditorMapObjectSpec(typeof(MapObjects.BluePhys), "Blue", "Colored blocks | Dynamic")]
    public static class EditorBluePhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BluePhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.BluePhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.BluePhys>(MapObjects.BluePhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.BluePhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.BluePhys>(MapObjects.BluePhysSpec.Deserialize);
    }
    
    #endregion
    
    #region YellowPhys
    
    [EditorMapObjectSpec(typeof(MapObjects.YellowPhys), "Yellow", "Colored blocks | Dynamic")]
    public static class EditorYellowPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.YellowPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.YellowPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.YellowPhys>(MapObjects.YellowPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.YellowPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.YellowPhys>(MapObjects.YellowPhysSpec.Deserialize);
    }
    
    #endregion
    
    #region PurplePhys
    
    [EditorMapObjectSpec(typeof(MapObjects.PurplePhys), "Purple", "Colored blocks | Dynamic")]
    public static class EditorPurplePhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.PurplePhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.PurplePhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.PurplePhys>(MapObjects.PurplePhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.PurplePhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.PurplePhys>(MapObjects.PurplePhysSpec.Deserialize);
    }
    
    #endregion
    
    #region OrangePhys
    
    [EditorMapObjectSpec(typeof(MapObjects.OrangePhys), "Orange", "Colored blocks | Dynamic")]
    public static class EditorOrangePhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.OrangePhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.OrangePhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.OrangePhys>(MapObjects.OrangePhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.OrangePhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.OrangePhys>(MapObjects.OrangePhysSpec.Deserialize);
    }
    
    #endregion
    
    #region BrownPhys
    
    [EditorMapObjectSpec(typeof(MapObjects.BrownPhys), "Brown", "Colored blocks | Dynamic")]
    public static class EditorBrownPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BrownPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.BrownPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.BrownPhys>(MapObjects.BrownPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.BrownPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.BrownPhys>(MapObjects.BrownPhysSpec.Deserialize);
    }
    
    #endregion
    
    #region PinkPhys
    
    [EditorMapObjectSpec(typeof(MapObjects.PinkPhys), "Pink", "Colored blocks | Dynamic")]
    public static class EditorPinkPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.PinkPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.PinkPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.PinkPhys>(MapObjects.PinkPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.PinkPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.PinkPhys>(MapObjects.PinkPhysSpec.Deserialize);
    }
    
    #endregion
    
    #region CyanPhys
    
    [EditorMapObjectSpec(typeof(MapObjects.CyanPhys), "Cyan", "Colored blocks | Dynamic")]
    public static class EditorCyanPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.CyanPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.CyanPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.CyanPhys>(MapObjects.CyanPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.CyanPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.CyanPhys>(MapObjects.CyanPhysSpec.Deserialize);
    }
    
    #endregion
    
    #region BlackPhys
    
    [EditorMapObjectSpec(typeof(MapObjects.BlackPhys), "Black", "Colored blocks | Dynamic")]
    public static class EditorBlackPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.BlackPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.BlackPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.BlackPhys>(MapObjects.BlackPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.BlackPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.BlackPhys>(MapObjects.BlackPhysSpec.Deserialize);
    }
    
    #endregion
    
    #region WhitePhys
    
    [EditorMapObjectSpec(typeof(MapObjects.WhitePhys), "White", "Colored blocks | Dynamic")]
    public static class EditorWhitePhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.WhitePhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.WhitePhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.WhitePhys>(MapObjects.WhitePhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.WhitePhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.WhitePhys>(MapObjects.WhitePhysSpec.Deserialize);
    }
    
    #endregion
    
    #region GreyPhys
    
    [EditorMapObjectSpec(typeof(MapObjects.GreyPhys), "Grey", "Colored blocks | Dynamic")]
    public static class EditorGreyPhys
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.GreyPhysSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.GreyPhys> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.GreyPhys>(MapObjects.GreyPhysSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.GreyPhys> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.GreyPhys>(MapObjects.GreyPhysSpec.Deserialize);
    }
    
    #endregion
    
    #endregion

}