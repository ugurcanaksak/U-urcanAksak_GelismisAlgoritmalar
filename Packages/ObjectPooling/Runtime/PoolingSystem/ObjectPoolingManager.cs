using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace RobotDreams.ObjectPooling
{
    public class ObjectPoolingManager : MonoBehaviour
    {
        public static ObjectPoolingManager Instance;

        [SerializeField]
        private List<PoolableObjectData> _objectsToPool = new List<PoolableObjectData>();

        private Dictionary<string, List<GameObject>> _pooledObjects = new Dictionary<string, List<GameObject>>();

        private void Awake()
        {
            Instance = this;
            Init();
        }

        private void Init()
        {
            //Create Clones
            //Go to each data in the _objectsToPool list
            foreach (var objectToPoolData in _objectsToPool)
            {
                //Create container
                var parent = new GameObject(objectToPoolData.ObjectName + "s").transform;
                parent.transform.SetParent(transform);

                //Init a new list to the dictionary for the clones
                var pooledObjectList = _pooledObjects[objectToPoolData.ObjectName] = new List<GameObject>();

                //Create clones
                for (int i = 0; i < objectToPoolData.Amount; i++)
                {
                    var cloneObject = CreateClone(objectToPoolData.Prefab, parent);
                    pooledObjectList.Add(cloneObject);

                }
            }
        }

        public GameObject GetPoolObject(string id, Vector3 position, Quaternion quaternion, Transform parent)
        {
            var go = GetPoolObject(id, position, quaternion);
            go.transform.SetParent(parent);
            return go;
        }


        public GameObject GetPoolObject(string id, Transform parent)
        {
            var go = GetPoolObject(id);
            go.transform.SetParent(parent);
            return go;
        }

        public GameObject GetPoolObject(string id, Vector3 position, Quaternion quaternion)
        {
            var go = GetPoolObject(id, position);
            go.transform.rotation = quaternion;
            return go;
        }

        public GameObject GetPoolObject(string id, Vector3 position)
        {
            var go = GetPoolObject(id);
            go.transform.position = position;
            return go;
        }


        public GameObject GetPoolObject(string id)
        {
            var cloneList = _pooledObjects[id];

            /*foreach (var clone in cloneList)
            {
                if (!clone.activeInHierarchy)
                    return clone;
            }*/

            var clone = cloneList.Where(clone => !clone.activeInHierarchy).FirstOrDefault();

            if (clone == null)
            {
                clone = CreateClone(_objectsToPool
                    .Where(objectData => string.Equals(objectData.ObjectName, id))
                    .FirstOrDefault().Prefab,
                    transform.Find(id + "s"));

                /* foreach (var objectData in _objectsToPool)
                 {
                     if (string.Equals(objectData.ObjectName, id))
                     {
                         clone = CreateClone(objectData.Prefab, transform.Find(id + "s"));
                         break;
                     }
                 }*/

                cloneList.Add(clone);
            }

            clone.SetActive(true);
            clone.GetComponent<IPooledObject>()?.Initialize();

            return clone;
        }

        private GameObject CreateClone(GameObject clonePrefab, Transform parent)
        {
            var cloneObject = Instantiate(clonePrefab, parent);
            cloneObject.SetActive(false);
            return cloneObject;
        }

        public void ReturnPooledObject(GameObject objectToReturn)
        {
            objectToReturn.GetComponent<IPooledObject>()?.Dismiss();
            objectToReturn.SetActive(false);
        }
    }
}
