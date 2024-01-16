using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.ScriptableObjectPattern
{
    [CreateAssetMenu(menuName = "RobotDreams/ScriptableObjectPattern/Components/MoverComponent")]

    public class MoverComponent : ScriptableObject
    {
        public FloatReference MovementSpeed;

        public void Move(Transform transform, Vector3 direction)
        {
            direction.y = 0;
            transform.Translate(direction * MovementSpeed * Time.deltaTime);
        }

    }
}
