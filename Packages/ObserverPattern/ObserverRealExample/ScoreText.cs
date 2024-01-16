using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.ObserverPattern.CharacterExample
{
    public class ScoreText : MonoBehaviour
    {
        private Text scoreTextComponent;
        private Text ScoreTextComponent { get { return scoreTextComponent == null? scoreTextComponent = GetComponent<Text>():scoreTextComponent; } }

        private void OnEnable()
        {
            EventManager.OnScoreUpdated.AddListener(UpdateScoreText);
        }

        private void OnDisable()
        {
            EventManager.OnScoreUpdated.RemoveListener(UpdateScoreText);
        }

        private void Start()
        {
            UpdateScoreText(0);
        }


        public void UpdateScoreText(int score)
        {
            ScoreTextComponent.text = score.ToString();
        }
    }
}
