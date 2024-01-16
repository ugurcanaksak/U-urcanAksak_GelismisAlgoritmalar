using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.AnimationRigging
{
    public interface IConstrainController 
    {
        void SetWeight(float weight);

        void AssignTarget(Transform target);
    }
}
