using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SingletonPattern.UseCase
{
    public class Player : MonoBehaviour
    {
        public static Player Instance;

        public float CurrentHealth;

        private void Awake()
        {
            Instance = this;
        }

        public virtual void RecieveDamage()
        {
            CurrentHealth--;
            AudioManager.Instance.PlayeSound();

        }
    }
}
