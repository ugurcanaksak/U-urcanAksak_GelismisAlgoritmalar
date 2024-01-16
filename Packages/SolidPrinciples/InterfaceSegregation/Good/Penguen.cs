using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.InterfaceSegregation.Good
{
    public class Penguen : MonoBehaviour, IEat, ISwim
    {
        public void Dive()
        {
            //dive
        }

        public void Eat()
        {
            //eat
        }

        public void Swim()
        {
            //swim
        }
    }

}
