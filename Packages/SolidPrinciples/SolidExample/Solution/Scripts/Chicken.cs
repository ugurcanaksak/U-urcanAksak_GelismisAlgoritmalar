using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SolidExample
{
    public class Chicken : MonoBehaviour, IDamageable
    {
        public void TakeDamage(float damage)
        {
            Debug.Log("Chicken Damaged");
        }

    }
}
