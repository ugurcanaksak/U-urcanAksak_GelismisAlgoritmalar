using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

namespace RobotDreams.SolidExample
{
    public class Damager : MonoBehaviour
    {
        public HealthBarVisualController HealthBarVisualController;

        void Damage(IDamageable damageable)
        {
            damageable.TakeDamage(1);
        }

        private void OnTriggerEnter(Collider other)
        {
            IDamageable damageable = other.GetComponent<IDamageable>(); 

            if (damageable != null)
            {
                Damage(damageable);
                HealthBarVisualController.SetHealthBar();
            }
        }
    }
}
