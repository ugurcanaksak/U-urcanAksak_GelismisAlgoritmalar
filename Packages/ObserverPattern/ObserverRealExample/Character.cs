using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.ObserverPattern.CharacterExample
{
    public class Character : MonoBehaviour
    {
        CharacterController controller;
        CharacterController CharacterController { get { return controller == null? controller =GetComponent<CharacterController>():controller; } }

        public float speed;

        private void Update()
        {
            CharacterController.Move(new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            Collectable collectable = other.GetComponent<Collectable>();

            if(collectable != null )
            {
                collectable.Collect();
            }
        }
    }
}
