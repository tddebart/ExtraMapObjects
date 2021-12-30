using MapsExt;
using MapsExt.MapObjects;
using UnboundLib;
using UnityEngine;

namespace ColoredBlocks
{
    public class MapObjects
    {
        #region Red

        public class Red : SpatialMapObject
        {
        }

        [MapObjectSpec(typeof(Red))]
        public static class RedSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapsExt.MapObjectSerializer]
            public static void Serialize(GameObject instance, Red target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Red data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                // BoilerPlate code
                ColoredBlocks.instance.ExecuteAfterFrames(1, () =>
                {
                    GameObject.Destroy(target.GetComponent<SpriteMask>());
                    GameObject.Destroy(target.GetComponent<SFPolygon>());
                });

                target.GetComponent<SpriteRenderer>().color = new Color(0.7132353f, 0.5784729f, 0.2884408f);
            }
        }

        #endregion
    }
}