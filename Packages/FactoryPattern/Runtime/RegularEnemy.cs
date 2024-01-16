using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    public class RegularEnemy : EnemyBase
    {
        public override EnemyType EnemyID => EnemyType.Regular;
    }
}
