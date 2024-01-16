using RobotDreams.DependencyInversion.Bad;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RobotDreams.DependencyInversion.Good
{
    public class AdManager : MonoBehaviour, IAdManager
    {
        private List<IAdService> _adServices;
        public List<IAdService> AdServices => _adServices ?? GetComponentsInChildren<IAdService>().ToList();

        public void ShowTheBestAd()
        {
            float best = 0f;
            string bestService = string.Empty;
            foreach (var adService in AdServices)
            {
                if(adService.GetAdValue() > best)
                {
                    best = adService.GetAdValue();
                    bestService = adService.ServiceIdentifier;
                }
            }

            AdServices.Where(x => string.Equals(x.ServiceIdentifier, bestService)).FirstOrDefault().ShowAd();

        }

        public void OnAdFinished()
        {
            Debug.Log("Ad Finished");
        }
    }
}

