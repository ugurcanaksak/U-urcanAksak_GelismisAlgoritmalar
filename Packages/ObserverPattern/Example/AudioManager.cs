using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.ObserverPattern
{
    public class AudioManager : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManager.OnPlayerKilled.AddListener(PlayEnemyKilledSound);
        }

        private void OnDisable()
        {
            EventManager.OnPlayerKilled.RemoveListener(PlayEnemyKilledSound);
        }

        public void PlayEnemyKilledSound(int value)
        {
            Debug.Log("EnemyKillSound Played");
        }
    }
}
