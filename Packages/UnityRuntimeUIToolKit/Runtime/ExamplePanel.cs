using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace RobotDreams.UIToolkitRuntime
{
    public class ExamplePanel : MonoBehaviour
    {
        public UIDocument document;

        [SerializeField]
        private bool isMute;


        private void Start()
        {
            var facebookLoginButton = document.rootVisualElement.Q<Button>("facebook-login");
            var soundToggle = document.rootVisualElement.Q<Toggle>("sound-status");
            var volumeSlider = document.rootVisualElement.Q<Slider>("volume-slider");

            facebookLoginButton.RegisterCallback<ClickEvent>(OnFacebookLogin);
            soundToggle.RegisterCallback<ChangeEvent<bool>>(OnSoundButtonClicked);
            volumeSlider.RegisterCallback<ChangeEvent<float>>(OnVolumeChange);

        }

        private void OnSoundButtonClicked(ChangeEvent<bool> evt)
        {
            isMute = evt.newValue;
        }

        private void OnFacebookLogin(ClickEvent evt)
        {
            Debug.Log("Logged in to facebook");
        }

        private void OnVolumeChange(ChangeEvent<float> volume)
        {
            Debug.Log($"Volume: {volume.newValue}");
        }
    }
}
