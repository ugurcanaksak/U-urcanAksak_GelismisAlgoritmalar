using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputProvider : MonoBehaviour
{
    public CharacterMovement Movement;
    public CharacterAttack Attack;

    private void Update()
    {
        RecieveMovementInput(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
    }

    private void RecieveMovementInput(Vector3 input)
    {

    }
}
