using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.DependencyInversion.Bad
{
    public interface IAdService
    {
        string ServiceIdentifier { get; }

        IAdManager AdManager { get; }

        float GetAdValue();

        void ShowAd();
    }
}

