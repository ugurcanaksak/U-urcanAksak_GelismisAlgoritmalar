using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float Speed;


   
    public void Move(Vector3 direction)
    {
        Debug.Log($"Moving to {direction}");
    }
}
