using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SolidExample
{
    public class CharacterDamager : MonoBehaviour
    {
        public HealthBarVisualController HealthBarVisualController;

        void Damage(ICharacterHealthController damageable)
        {
            damageable.TakeDamage(1);
        }

        private void OnTriggerEnter(Collider other)
        {
            ICharacterHealthController damageable = other.GetComponent<ICharacterHealthController>();

            if (damageable != null)
            {
                Damage(damageable);
                HealthBarVisualController.SetHealthBar();
            }
        }
    }
}
