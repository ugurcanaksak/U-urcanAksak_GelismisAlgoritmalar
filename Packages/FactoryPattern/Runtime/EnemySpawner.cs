using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    public class EnemySpawner : MonoBehaviour
    {
        public List<EnemyType> EnemyTypes;
        public float waitTime;

        public EnemyFactory EnemyFactory;

        private IEnumerator Start()
        {
            while (true)
            {
                for (int i = 0; i < EnemyTypes.Count; i++)
                {
                    yield return new WaitForSeconds(waitTime);
                    var enemy = EnemyFactory.CreateEnemy(EnemyTypes[i]);
                    Debug.Log($"{gameObject.name} created {enemy.EnemyID}");
                }
            }
            
        }
    }
}
