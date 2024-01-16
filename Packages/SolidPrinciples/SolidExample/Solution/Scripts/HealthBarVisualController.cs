using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.SolidExample
{
    public class HealthBarVisualController : MonoBehaviour, ICharacterUIController
    {
        private Slider _slider;
        private Slider Slider => _slider?? GetComponent<Slider>();

        private ICharacterHealthController _characterHealthController;
        private ICharacterHealthController CharacterHealthController => _characterHealthController?? FindAnyObjectByType<CharacterHealthController>();

        private void Start()
        {
            IntializeHealthBar();
        }

        void IntializeHealthBar()
        {
            Slider.maxValue = CharacterHealthController.MaxHealth;
        }

        public void SetHealthBar()
        {
            Slider.value = CharacterHealthController.CurrentHealth;

        }
    }
}
