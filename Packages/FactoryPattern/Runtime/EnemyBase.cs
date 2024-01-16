using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.FactoryPattern
{
    public abstract class EnemyBase 
    {
        public abstract EnemyType EnemyID { get; }
    }
}
