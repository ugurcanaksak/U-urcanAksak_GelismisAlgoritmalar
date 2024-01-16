using RobotDreams.DependencyInversion.Bad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAdManager 
{
    List<IAdService> AdServices { get; }
    public void ShowTheBestAd();
    public void OnAdFinished();
}
