using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RobotDreams.EditorExtensions.Editor
{

    public class PropBuilderWindow : EditorWindow
    {
        GameObject Model;
        Material Material;

        [MenuItem("RobotDreams/PropBuilder")]
        public static void ShowWindow()
        {
            GetWindow<PropBuilderWindow>().Show();
        }

        private void OnGUI()
        {
            Model = (GameObject)EditorGUILayout.ObjectField("GameObject", Model, typeof(GameObject), true);
            Material = (Material)EditorGUILayout.ObjectField("GameObject", Material, typeof(Material), true);

            if(GUILayout.Button("CreatePrefab"))
            {
                Debug.Log("PrefabCreated");
            }
        }
    }
}
