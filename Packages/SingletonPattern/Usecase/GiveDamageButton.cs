using RobotDreams.SingletonPattern.UseCase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.SingletonPattern.UseCase
{
    public class GiveDamageButton : MonoBehaviour
    {
        private Button _button;
        private Button Button => _button?? GetComponent<Button>();

        private void OnEnable()
        {
            Button.onClick.AddListener(GiveDamage);
        }

        private void OnDisable()
        {
            Button.onClick.RemoveListener(GiveDamage);
        }

        private void GiveDamage()
        {
            Player.Instance.RecieveDamage();
        }
    }
}
