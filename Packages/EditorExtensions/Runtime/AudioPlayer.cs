using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.EditorExtensions
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioPlayer : MonoBehaviour
    {
        private AudioSource _audioSource;
        public AudioSource AudioSource { get { return _audioSource == null? _audioSource = GetComponent<AudioSource>(): _audioSource; } }

        [HideInInspector]
        public AudioClip AudioClip;

        [Range(0.0f, 1.0f)]
        public float Volume;

        private void OnValidate()
        {
            AudioSource.hideFlags = HideFlags.HideInInspector;
        }


        public void PlayAudio()
        {
            AudioSource.volume = Volume;
            AudioSource.PlayOneShot(AudioClip);
        }
    }
}
