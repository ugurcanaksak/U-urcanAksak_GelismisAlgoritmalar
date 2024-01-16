using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : WeaponBase
{
    public override void Fire()
    {
        Debug.Log("Pistol Fired");
        PlayParticleEffect();
        PlaySound();
    }

    protected override void PlaySound()
    {
        base.PlaySound();
        Debug.Log("PistolFireSoundPlayed");
    }
}
