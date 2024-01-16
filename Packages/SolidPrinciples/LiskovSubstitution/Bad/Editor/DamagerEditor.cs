using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RobotDreams.LiskovSubstitution.Bad
{
    [CustomEditor(typeof(Damager))]
    public class DamagerEditor : Editor
    {
        private Damager _damager;

        private void OnEnable()
        {
            _damager = (Damager)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Damage"))
                _damager.ApplyDamage();
        }
    }
}

