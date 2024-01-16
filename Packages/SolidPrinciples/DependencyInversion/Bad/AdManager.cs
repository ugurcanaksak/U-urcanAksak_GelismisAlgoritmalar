using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.DependencyInversion.Bad
{
    public class AdManager : MonoBehaviour
    {
        public AdMobAdManager AdMobAdManager;
        public UnityAdManager UnityAdManager;

        public void ShowTheBestAd()
        {
            if (UnityAdManager.GetAdValue() > AdMobAdManager.GetAdValue())
            {

                UnityAdManager.ShowAd();
            }
            else
            {
                AdMobAdManager.ShowAd();
            }
        }

        public void OnAdFinished()
        {
            Debug.Log("Ad Finished");
        }
    }
}

