using UnityEngine;

namespace RobotDreams.SolidPrinciples.Homework.OpenClose
{
    public class Enemy : MonoBehaviour
    {
        public string enemyType;

        void Update()
        {
            if (enemyType == "Zombie")
            {
                // Zombie behavior
            }
            else if (enemyType == "Alien")
            {
                // Alien behavior
            }
            // For each new enemy type, we have to add a new else if block
        }
    }
}

