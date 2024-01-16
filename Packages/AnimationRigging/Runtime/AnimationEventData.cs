using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.AnimationRigging
{
    [CreateAssetMenu(fileName = "Animation Data", menuName = "RobotDreams/AnimationRigging/AnimationData", order = 1)]
    public class AnimationEventData : ScriptableObject
    {
        public float FloatData;
        public int IntData;
        public bool boolData;
        public string stringData;
    }
}
