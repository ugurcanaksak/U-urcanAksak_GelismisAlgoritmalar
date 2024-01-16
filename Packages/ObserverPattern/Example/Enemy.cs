using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace RobotDreams.ObserverPattern
{
    public class Enemy : MonoBehaviour
    {

        AudioSource audioSource;
        public List<AudioClip> clipList;

        public void KillEnemy()
        {
            EventManager.OnPlayerKilled.Invoke(1);
            Debug.Log("Enemy Killed");
        }



        public void KillEnemy2()
        {
            KillEnemy();
            PlaySound(1, null);
        }

        public void PlayParticleEffect()
        {

        }

        public async Task PlaySound(int clipIndex, Action onComplete)
        {
            audioSource.clip = clipList[clipIndex];
            audioSource.Play();
            await Task.Delay((int)clipList[clipIndex].length);
            onComplete?.Invoke();
        }
    }
}
