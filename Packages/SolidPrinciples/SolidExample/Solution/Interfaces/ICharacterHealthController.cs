using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RobotDreams.SolidExample
{
    public interface ICharacterHealthController : IDamageable, IHealable
    {
        float MaxHealth { get; }
        float CurrentHealth { get; set; }
    }
}
