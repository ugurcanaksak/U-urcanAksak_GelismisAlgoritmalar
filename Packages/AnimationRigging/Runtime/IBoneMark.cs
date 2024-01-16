using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.AnimationRigging
{
    public interface IBoneMark 
    {
        string BoneId { get; }

        void SetBoneWeight(float weight);

        void StartLookingForTarget();
        void StopLookingForTarget();
    }
}
