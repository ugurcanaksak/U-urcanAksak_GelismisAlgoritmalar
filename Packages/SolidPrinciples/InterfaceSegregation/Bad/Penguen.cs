using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.InterfaceSegregation.Bad
{
    public class Penguen : MonoBehaviour, IBird
    {
        public void Eat()
        {
            Debug.Log("Eat Food");
        }

        public void Fly()
        {
            throw new System.Exception("Can't Fly");
        }

        public void Swim()
        {
            Debug.Log("Swim");
        }
    }

}
