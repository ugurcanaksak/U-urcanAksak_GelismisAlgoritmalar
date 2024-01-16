using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RobotDreams.EditorExtensions.Editor
{
    [CustomEditor(typeof(AudioPlayer))]
    public class AudioPlayerEditor : UnityEditor.Editor
    {
        AudioPlayer AudioPlayer;


        private void OnEnable()
        {
            AudioPlayer = (AudioPlayer)target;
            AudioPlayer.AudioSource.hideFlags = HideFlags.HideInInspector;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            AudioPlayer.AudioClip = (AudioClip)EditorGUILayout.ObjectField("Audio Clip", AudioPlayer.AudioClip, typeof(AudioClip), false, GUILayout.Height(100));

            // Draw AudioClip data if it's not null
            if (AudioPlayer.AudioClip != null)
            {
                EditorGUILayout.LabelField("Sample Rate", AudioPlayer.AudioClip.frequency.ToString());
                EditorGUILayout.LabelField("Length", AudioPlayer.AudioClip.length.ToString());
                // Add more fields as needed...
            }

            if (GUILayout.Button("Play Audio"))
            {
                AudioPlayer.PlayAudio();
            }
        }
    }
}
