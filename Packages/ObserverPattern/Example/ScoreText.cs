using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.ObserverPattern
{
    public class ScoreText : MonoBehaviour
    {
        public Text scoreText;

        private int score;

        private void OnEnable()
        {
            EventManager.OnPlayerKilled.AddListener(UpdateScoreText);
        }

        private void OnDisable()
        {
            EventManager.OnPlayerKilled.RemoveListener(UpdateScoreText);
        }

        public void Update()
        {
            scoreText.text = score.ToString();
        }

        public void UpdateScoreText(int value)
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
