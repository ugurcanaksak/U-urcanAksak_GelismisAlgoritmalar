using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.InterfaceSegregation.Good
{
    public class Pigeon : MonoBehaviour, IEat, IFly
    {
        #region Consume
        public void Eat()
        {
            //eat
        }
        #endregion

        #region Fly
        public void Fly()
        {
            //fly
        }

        public void TakeOff()
        {
            //takeoff
        }

        public void Land()
        {
            //land
        }
        #endregion


    }

}
