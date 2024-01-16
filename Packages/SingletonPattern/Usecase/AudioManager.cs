using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SingletonPattern.UseCase
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        public void PlayeSound()
        {
            Debug.Log("Sound Played");
        }
    }
}
