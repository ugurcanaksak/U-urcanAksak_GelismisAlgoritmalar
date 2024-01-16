using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace RobotDreams.LiskovSubstitution.Bad
{
    public class Damager : MonoBehaviour
    {
        public void ApplyDamage()
        {
            var enemy = GetComponent<Enemy>();
            var bossEnemy = GetComponent<BossEnemy>();

            if(enemy != null)
            {
                enemy.TakeDamage();
            }
            else
            {
                bossEnemy.TakeDamage();
            }    
        }
    }
}
   
