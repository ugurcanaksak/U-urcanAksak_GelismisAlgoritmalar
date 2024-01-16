using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public float health;

    public float maxHealth;

    public void TakeDamage(float damage)
    {
        Debug.Log($"Damage Taken {damage}");
    }

    public void GainHealth(float health)
    {
        Debug.Log($"Health Gained {health}");
    }
}
