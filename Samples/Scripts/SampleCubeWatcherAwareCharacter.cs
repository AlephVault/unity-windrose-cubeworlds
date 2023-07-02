using AlephVault.Unity.WindRose.Authoring.Behaviours.Entities.Objects;
using AlephVault.Unity.WindRose.CubeWorlds.Authoring.Behaviours.Entities;
using AlephVault.Unity.WindRose.Types;
using UnityEngine;


namespace AlephVault.Unity.WindRose.CubeWorlds
{
    namespace Samples
    {
        [RequireComponent(typeof(CubeFollowed))]
        public class SampleCubeWatcherAwareCharacter : MonoBehaviour
        {
            // Start is called before the first frame update
            private MapObject obj;

            // Start is called before the first frame update
            void Awake()
            {
                obj = GetComponent<MapObject>();
            }

            // Update is called once per frame
            void Update()
            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    obj.Orientation = Direction.DOWN;
                    obj.StartMovement(Direction.DOWN);
                }
                else if (Input.GetKey(KeyCode.UpArrow))
                {
                    obj.Orientation = Direction.UP;
                    obj.StartMovement(Direction.UP);
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    obj.Orientation = Direction.LEFT;
                    obj.StartMovement(Direction.LEFT);
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    obj.Orientation = Direction.RIGHT;
                    obj.StartMovement(Direction.RIGHT);
                }
            }
        }
    }
}

