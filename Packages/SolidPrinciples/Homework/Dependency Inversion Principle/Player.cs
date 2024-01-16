using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SolidPrinciples.Homework.DependencyInversion 
{
    public class Player
    {
        private Sword _sword;

        public Player()
        {
            _sword = new Sword(); // Player is directly dependent on the Sword class (a low-level module)
        }

        public void Attack()
        {
            _sword.Swing();
        }
    }
}
