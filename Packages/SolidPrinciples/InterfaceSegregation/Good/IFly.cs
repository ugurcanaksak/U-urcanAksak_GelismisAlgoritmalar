using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RobotDreams.InterfaceSegregation.Good
{
    public interface IFly 
    {
        void Fly();
        void TakeOff();
        void Land();
    }
}

