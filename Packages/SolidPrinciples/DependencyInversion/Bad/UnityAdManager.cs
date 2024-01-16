using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RobotDreams.DependencyInversion.Bad
{
    public class UnityAdManager : MonoBehaviour
    {
        public float AdValue;
        public AdManager AdManager;

        public float GetAdValue()
        {
            return AdValue; //Ask a service how much they are paying to show their ad
        }

        public void ShowAd()
        {
            Debug.Log($"Showing Ad from {this.GetType().Name}");
            AdManager.OnAdFinished();
        }
    }
}