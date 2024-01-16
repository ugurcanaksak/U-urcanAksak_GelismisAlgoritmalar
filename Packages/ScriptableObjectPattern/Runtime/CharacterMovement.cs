using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.ScriptableObjectPattern
{
    public class CharacterMovement : MonoBehaviour
    {
        public MoverComponent moverComponent;

        private bool canMove;

        private void Update()
        {
            if (canMove)
                moverComponent.Move(transform, new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        }

        public void SetCanMove()
        {
            canMove = !canMove;
        }
    }
}
