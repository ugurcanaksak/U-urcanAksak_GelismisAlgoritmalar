using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    public class ZombieEnemy : EnemyBase
    {
        public override EnemyType EnemyID => EnemyType.Zombie;
    }
}
