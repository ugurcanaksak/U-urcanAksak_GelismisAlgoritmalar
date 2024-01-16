using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SingletonPattern.Problem
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float CurrentHealth;
        [SerializeField] AudioManager AudioManager;

        public void RecieveDamage() 
        { 
            CurrentHealth--;
            AudioManager.PlayHurtAudio();
        }
    }
}
