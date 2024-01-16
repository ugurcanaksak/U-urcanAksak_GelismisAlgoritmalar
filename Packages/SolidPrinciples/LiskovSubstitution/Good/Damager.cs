using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.LiskovSubstitution.Good
{
    public class Damager : MonoBehaviour
    {
        private IDamageable _damageable;
        private IDamageable Damageable => _damageable ?? GetComponent<IDamageable>();

        public void ApplyDamage()
        {
            Damageable.TakeDamage();
        }
    }
}

