using RobotDreams.DependencyInversion.Bad;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace RobotDreams.DependencyInversion.Good
{
    [CustomEditor(typeof(AdManager))]
    public class AdManagerEditor : Editor
    {
        private AdManager _adManager;

        private void OnEnable()
        {
            _adManager = (AdManager)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("ShowBestAd"))
                _adManager.ShowTheBestAd();
        }
    }

}
