using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.LiskovSubstitution.Good
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        private Animator _animator;
        private Animator Animator => _animator ?? GetComponent<Animator>();

        public void TakeDamage()
        {
            Animator.SetTrigger("damage");
        }
    }
}

