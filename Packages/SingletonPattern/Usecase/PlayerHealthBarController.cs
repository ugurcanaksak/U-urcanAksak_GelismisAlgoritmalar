using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.SingletonPattern.UseCase
{
    public class PlayerHealthBarController : MonoBehaviour
    {
        Slider _slider;
        Slider Slider => _slider?? GetComponent<Slider>();

        private void Update()
        {
            Slider.value = Player.Instance.CurrentHealth;
        }
    }
}
