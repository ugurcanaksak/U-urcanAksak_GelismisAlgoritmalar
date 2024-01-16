using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    public interface IEnemyFactory 
    {
        public EnemyBase CreateEnemy(EnemyType enemyType);
    }
}
