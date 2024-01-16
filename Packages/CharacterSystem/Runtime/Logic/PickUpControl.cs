using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.CharacterSystem
{
    public class PickUpControl : CharacterHealthControllerBase
    {
        public override void Heal(float health)
        {
            Debug.Log("Health Taken");
            HealthData.MaxHealth+=health;
        }

        public override void TakeDamage(float damage)
        {
            Debug.Log("Damage Taken");
            HealthData.MaxHealth-=damage;
        }

        private void OnTriggerEnter(Collider coll){
            if(coll.gameObject.tag == "Heal"){
                Heal(10);
                Destroy(coll.gameObject);
            }else if(coll.gameObject.name == "Enemy"){
                TakeDamage(10);
                Destroy(coll.gameObject);
            }
        }
    }
}
