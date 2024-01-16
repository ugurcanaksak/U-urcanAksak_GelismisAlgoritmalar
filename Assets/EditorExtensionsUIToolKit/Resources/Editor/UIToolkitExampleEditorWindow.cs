using PlasticGui.WorkspaceWindow.CodeReview;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UIToolkitExampleEditorWindow : EditorWindow
{
    private IntegerField optionA;
    private IntegerField optionB;
    private Button confirmButton;
    private SliderInt slider;

    [MenuItem("RobotDreams/ExampleUIWindow")]
    public static void OpenWindow()
    {
        GetWindow<UIToolkitExampleEditorWindow>().Show();
    }

    private void CreateGUI()
    {
        VisualElement root = rootVisualElement;

        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/EditorExtensionsUIToolKit/Resources/UIDocument/ExampleWindowDocument.uxml");

        VisualElement tree = visualTree.Instantiate();
        root.Add(tree);

        optionA = root.Q<IntegerField>("option-a");
        optionB = root.Q<IntegerField>("option-b");
        confirmButton = root.Q<Button>("confirm-button");
        slider = root.Q<SliderInt>();

        confirmButton.clicked += Confirm;

        slider.RegisterValueChangedCallback<int>(OnSliderChanged);
        
    }

    private void OnSliderChanged(ChangeEvent<int> evt)
    {
        Debug.Log(evt.newValue);
    }

    private void Confirm()
    {
        Debug.Log($"{optionA.value} {optionB.value} values Confirmed");
    }
}
