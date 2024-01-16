using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WeaponBase), true)]
[CanEditMultipleObjects]
public class WeaponEditor : Editor
{
    private WeaponBase weapon;

    private void OnEnable()
    {
        weapon = (WeaponBase)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Fire"))
            weapon.Fire();
    }
}
