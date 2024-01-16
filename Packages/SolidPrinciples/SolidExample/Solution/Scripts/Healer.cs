using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SolidExample
{
    public class Healer : MonoBehaviour
    {
        public HealthBarVisualController HealthBarVisualController;

        void Heal(IHealable healable)
        {
            healable.Heal(1);
        }

        private void OnTriggerEnter(Collider other)
        {
            IHealable healable = other.GetComponent<IHealable>(); 

            if (healable != null) 
            { 
                Heal(healable);
                HealthBarVisualController.SetHealthBar();
            }
        }
    }
}
