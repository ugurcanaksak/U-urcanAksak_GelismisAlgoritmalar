using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RobotDreams.ObserverPattern.CharacterExample
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager instance;
        
        public int currentScore = 0;


       
        private void Awake()
        {
            instance = this;
        }

        private void OnEnable()
        {
            EventManager.OnCollectableCollected.AddListener(UpdateScore);
        }

        private void OnDisable()
        {
            EventManager.OnCollectableCollected.RemoveListener(UpdateScore);
        }

        public void UpdateScore(int amount)
        {
            currentScore += amount;
            EventManager.OnScoreUpdated.Invoke(currentScore);
        }

    }
}
