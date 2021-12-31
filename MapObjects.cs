using System;
using MapsExt;
using MapsExt.MapObjects;
using UnboundLib;
using UnityEngine;

namespace ExtraMapObjects
{
    public class MapObjects
    {
        private static readonly Material defaultMaterial = new Material(Shader.Find("Sprites/Default"));

        public static void Deserialize(GameObject target, Color color)
        {
            ExtraMapObjects.instance.ExecuteAfterFrames(2, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
        }
        
        #region Red

        public class Red : SpatialMapObject
        {
        }

        [MapObjectSpec(typeof(Red))]
        public static class RedSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Red target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Red data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.red*0.8f);
            }
        }

        #endregion
        
        #region Green

        public class Green : SpatialMapObject
        {
        }

        [MapObjectSpec(typeof(Green))]
        public static class GreenSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Green target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Green data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.green*0.8f);
            }
        }

        #endregion
        
        #region Blue

        public class Blue : SpatialMapObject
        {
        }

        [MapObjectSpec(typeof(Blue))]
        public static class BlueSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Blue target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Blue data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.blue*0.8f);
            }
        }

        #endregion
        
        #region Yellow
        
        public class Yellow : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Yellow))]
        public static class YellowSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Yellow target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Yellow data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.yellow*0.8f);
            }
        }
        
        #endregion
        
        #region Purple
        
        public class Purple : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Purple))]
        public static class PurpleSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Purple target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Purple data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.5f, 0f, 0.9f));
            }
        }
        
               
        #endregion
        
        #region Orange
        
        public class Orange : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Orange))]
        public static class OrangeSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Orange target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Orange data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(1f, 0.5f, 0f)*0.8f);
            }
        }
        
        #endregion
        
        #region Brown
        
        public class Brown : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Brown))]
        public static class BrownSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Brown target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Brown data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.5f, 0.25f, 0f));
            }
        }
        
        #endregion
        
        #region Pink
        
        public class Pink : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Pink))]
        public static class PinkSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Pink target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Pink data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.9f, 0.4f, 0.7f));
            }
        }
        
        #endregion
        
        #region Cyan
        
        public class Cyan : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Cyan))]
        public static class CyanSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Cyan target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Cyan data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.1f, 0.8f, 0.8f)*0.8f);
            }
        }
        
        #endregion
        
        #region Black
        
        public class Black : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Black))]
        public static class BlackSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Black target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Black data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0, 0, 0));
            }
        }
        
        #endregion
        
        #region White
        
        public class White : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(White))]
        public static class WhiteSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, White target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(White data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(1f, 1f, 1f)*0.8f);
            }
        }
        
        #endregion
        
        #region Grey
        
        public class Grey : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(Grey))]
        public static class GreySpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Grey target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Grey data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.4f, 0.4f, 0.4f));
            }
        }
        
        #endregion
    }
}