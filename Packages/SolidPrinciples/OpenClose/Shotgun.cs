using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : WeaponBase
{
    public int FireCount;
    public override void Fire()
    {
        for (int i = 0; i < FireCount; i++)
        {
            Debug.Log("Shotgun Fired");
            PlayParticleEffect();
            PlaySound();
        } 
    }

    protected override void PlaySound()
    {
        base.PlaySound();
        Debug.Log("ShotgunFired");
    }
}
