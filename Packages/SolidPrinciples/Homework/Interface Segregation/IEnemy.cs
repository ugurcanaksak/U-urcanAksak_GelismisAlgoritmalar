using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SolidPrinciples.Homework.InterfaceSegregation
{
    public interface IEnemy
    {
        void Attack();
        void Defend();
        void Heal();
    }

    public class BasicEnemy : IEnemy
    {
        public void Attack() { /*...*/ }
        public void Defend() { /*...*/ }
        public void Heal() { /*...*/ } // BasicEnemy doesn't need to heal, but it's forced to implement this method
    }

}
