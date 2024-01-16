using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SolidExample
{
    public class CharacterHealthController : MonoBehaviour, ICharacterHealthController
    {

        public float MaxHealth => 100;

        [SerializeField]
        private float _currentHealth;
        public float CurrentHealth { get { return _currentHealth; } set { _currentHealth = value; } }

        private void Start()
        {
            CurrentHealth = MaxHealth;
        }

        public void Heal(float healAmount)
        {
            Debug.Log("Healed");
            _currentHealth += healAmount;
        }

        public void TakeDamage(float damage)
        {
            Debug.Log("Damaged");
            _currentHealth -= damage;
        }
    }
}
