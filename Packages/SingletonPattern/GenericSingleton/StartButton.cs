using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.SingletonPattern.GenericSingleton
{
    public class StartButton : MonoBehaviour
    {
        private Button button;
        private Button Button => button?? GetComponent<Button>();

        private void OnEnable()
        {
            Button.onClick.AddListener(StartGame);
        }

        private void OnDisable()
        {
            Button.onClick.RemoveListener(StartGame);
        }

        private void StartGame()
        {
            GameManager.Instance.StarGame();
        }    
    }
}
