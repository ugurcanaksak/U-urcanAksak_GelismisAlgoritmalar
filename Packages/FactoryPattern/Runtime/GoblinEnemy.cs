using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    public class GoblinEnemy : EnemyBase
    {
        public override EnemyType EnemyID => EnemyType.Goblin;
    }
}
