using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    public int foo { get; private set; }

    [SerializeField] private Transform FirePoint;
    [SerializeField] private float FireRate;


    [SerializeField] private GameObject ShotParticle;
    private int bulletsInMagazine;

    public virtual int GetWeaponMagazineStatus()
    {
        return bulletsInMagazine;
    }


    public abstract void Fire();

    protected virtual void PlayParticleEffect()
    {
        var effect = Instantiate(ShotParticle, FirePoint.transform.position, Quaternion.identity);
        Destroy(effect, 2);
    } 

    protected virtual void PlaySound()
    {
        Debug.Log("WeaponFireSoundPlayed");
    }
}
