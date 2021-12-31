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
            ExtraMapObjects.instance.ExecuteAfterFrames(1, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
            ExtraMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
        }
        
        public static void DeserializePhys(GameObject target, Color color)
        {
            ExtraMapObjects.instance.ExecuteAfterFrames(1, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
            ExtraMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
        }
        
        public static void DeserializePhysBack(GameObject target, Color color)
        {
            ExtraMapObjects.instance.ExecuteAfterFrames(1, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().enabled = true;   
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                target.GetComponent<SpriteRenderer>().color = color;
            });
            ExtraMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().enabled = true;   
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f; 
                target.GetComponent<SpriteRenderer>().color = color;
            });
        }
        
        #region Normal objects
        
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
        
        #endregion
        
        #region Dynamic objects

        #region RedPhys

        public class RedPhys : SpatialMapObject
        {
        }

        [MapObjectSpec(typeof(RedPhys))]
        public static class RedPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, RedPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(RedPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.red*0.8f);
            }
        }

        #endregion
        
        #region GreenPhys
        
        public class GreenPhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(GreenPhys))]
        public static class GreenPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreenPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreenPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.green*0.8f);
            }
        }
        
        #endregion
        
        #region BluePhys
        
        public class BluePhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(BluePhys))]
        public static class BluePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BluePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BluePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.blue*0.8f);
            }
        }
        
        #endregion
        
        #region YellowPhys
        
        public class YellowPhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(YellowPhys))]
        public static class YellowPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, YellowPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(YellowPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.yellow*0.8f);
            }
        }
        
        #endregion
        
        #region PurplePhys
        
        public class PurplePhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(PurplePhys))]
        public static class PurplePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PurplePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PurplePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.5f, 0f, 0.9f));
            }
        }
        
        #endregion
        
        #region OrangePhys
        
        public class OrangePhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(OrangePhys))]
        public static class OrangePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, OrangePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(OrangePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(1f, 0.5f, 0f)*0.8f);
            }
        }
        
        #endregion
        
        #region BrownPhys
        
        public class BrownPhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(BrownPhys))]
        public static class BrownPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BrownPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BrownPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.5f, 0.25f, 0f));
            }
        }
        
        #endregion
        
        #region PinkPhys
        
        public class PinkPhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(PinkPhys))]
        public static class PinkPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PinkPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PinkPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.9f, 0.4f, 0.7f));
            }
        }
        
        #endregion
        
        #region CyanPhys
        
        public class CyanPhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(CyanPhys))]
        public static class CyanPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, CyanPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(CyanPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.1f, 0.8f, 0.8f)*0.8f);
            }
        } 
        
        #endregion
        
        #region BlackPhys
        
        public class BlackPhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(BlackPhys))]
        public static class BlackPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BlackPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BlackPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0,0,0));
            }
        }
        
        #endregion
        
        #region WhitePhys
        
        public class WhitePhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(WhitePhys))]
        public static class WhitePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, WhitePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(WhitePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(1f, 1f, 1f)*0.8f);
            }
        }
        
        #endregion
        
        // Grey
        #region GreyPhys
        
        public class GreyPhys : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(GreyPhys))]
        public static class GreyPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreyPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreyPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.4f, 0.4f, 0.4f));
            }
        }
        
        #endregion
        
        #endregion
        
        
        
        
        #region RedPhysBackg

        public class RedPhysBackg : SpatialMapObject
        {
        }

        [MapObjectSpec(typeof(RedPhysBackg))]
        public static class RedPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, RedPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(RedPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.red*0.8f);
            }
        }

        #endregion
        
        #region GreenPhysBackg
        
        public class GreenPhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(GreenPhysBackg))]
        public static class GreenPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreenPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreenPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.green*0.8f);
            }
        }
        
        #endregion
        
        #region BluePhysBackg
        
        public class BluePhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(BluePhysBackg))]
        public static class BluePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BluePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BluePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.blue*0.8f);
            }
        }
        
        #endregion
        
        #region YellowPhysBackg
        
        public class YellowPhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(YellowPhysBackg))]
        public static class YellowPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, YellowPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(YellowPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow*0.8f);
            }
        }
        
        #endregion
        
        #region PurplePhysBackg
        
        public class PurplePhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(PurplePhysBackg))]
        public static class PurplePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PurplePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PurplePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.magenta*0.8f);
            }
        }
        
        #endregion
        
        //Orange
        #region OrangePhysBackg
        
        public class OrangePhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(OrangePhysBackg))]
        public static class OrangePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, OrangePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(OrangePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow*0.8f);
            }
        }
        
        #endregion
        
        
        #region BrownPhysBackg
        
        public class BrownPhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(BrownPhysBackg))]
        public static class BrownPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BrownPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BrownPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow*0.8f);
            }
        }
        
        #endregion
        
        
        #region PinkPhysBackg
        
        public class PinkPhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(PinkPhysBackg))]
        public static class PinkPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PinkPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PinkPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow*0.8f);
            }
        }
        
        #endregion
        
        // Cyan
        #region CyanPhysBackg
        
        public class CyanPhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(CyanPhysBackg))]
        public static class CyanPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, CyanPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(CyanPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.cyan*0.8f);
            }
        }
        
        #endregion
        
        // Black
        #region BlackPhysBackg
        
        public class BlackPhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(BlackPhysBackg))]
        public static class BlackPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BlackPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BlackPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.black*0.8f);
            }
        }
        
        #endregion
        
        // White
        #region WhitePhysBackg
        
        public class WhitePhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(WhitePhysBackg))]
        public static class WhitePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, WhitePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(WhitePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.white*0.8f);
            }
        }
        
        #endregion
        
        // Grey
        #region GreyPhysBackg
        public class GreyPhysBackg : SpatialMapObject
        {
        }
        
        [MapObjectSpec(typeof(GreyPhysBackg))]
        public static class GreyPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreyPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreyPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.grey*0.8f);
            }
        }
        
        #endregion
    }
}