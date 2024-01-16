using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.SingletonPattern.Problem
{
    public class DamageButton : MonoBehaviour
    {
        private Button _button;
        private Button Button => _button?? GetComponent<Button>();

        [SerializeField] private Player player;

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
            player.RecieveDamage();
        }
    }
}
