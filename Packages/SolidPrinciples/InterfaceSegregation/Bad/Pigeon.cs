using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RobotDreams.InterfaceSegregation.Bad
{
    public class Pigeon : MonoBehaviour, IBird
    {
        public void Eat()
        {
            Debug.Log("Eat Food");
        }

        public void Fly()
        {
            Debug.Log("Fly");
        }

        public void Swim()
        {
            throw new System.Exception("Can't Swim");
        }
    }
}
