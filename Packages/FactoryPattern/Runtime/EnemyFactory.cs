using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    [CreateAssetMenu(fileName = "EnemyFactory", menuName = "RobotDreams/FactoryPattern/EnemyFactory", order = 1)]
    public class EnemyFactory : ScriptableObject, IEnemyFactory
    {

        private Dictionary<EnemyType, EnemyBase> enemyCollection;
        private Dictionary<EnemyType, EnemyBase> EnemyCollection
        {
            get
            {
                if(enemyCollection == null)
                {
                    enemyCollection = new Dictionary<EnemyType, EnemyBase> ();

                    enemyCollection[EnemyType.Regular] = new RegularEnemy();
                    enemyCollection[EnemyType.Zombie] = new ZombieEnemy();
                    enemyCollection[EnemyType.Goblin] = new GoblinEnemy();
                    enemyCollection[EnemyType.Skeleton] = new SkeletonEnemy();
                }
                return enemyCollection;
            }
        }

        public EnemyBase CreateEnemy(EnemyType enemyType)
        {
            return EnemyCollection[enemyType];
        }
    }
}
