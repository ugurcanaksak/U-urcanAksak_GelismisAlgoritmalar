using RobotDreams.DependencyInversion.Bad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdMobAdService : MonoBehaviour, IAdService
{
    public string ServiceIdentifier => "AdMobService";


    [SerializeField] private float _adValue;

    private IAdManager _adManager;
    public IAdManager AdManager => _adManager ?? GetComponent<IAdManager>();

    public float GetAdValue()
    {
        return _adValue;
    }

    public void ShowAd()
    {
        //do Admob service stuff
        Debug.Log($"Showing Ad from {ServiceIdentifier}");
        AdManager.OnAdFinished();
    }
}
