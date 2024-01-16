using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    public class SkeletonEnemy : EnemyBase
    {
        public override EnemyType EnemyID => EnemyType.Skeleton;
    }
}
