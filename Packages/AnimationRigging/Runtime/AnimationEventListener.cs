using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

namespace RobotDreams.AnimationRigging
{
    public class AnimationEventListener : MonoBehaviour
    {
        private List<IBoneMark> boneMarks;
        private List<IBoneMark> BoneMarks { get { return boneMarks == null ? boneMarks = new List<IBoneMark>(GetComponentsInChildren<IBoneMark>()) : boneMarks; } }

        public void SetWeight(AnimationEventData animationEvent)
        {
            //BoneMarks.Where(b => string.Equals(b.BoneId, animationEvent.stringData)).FirstOrDefault().SetBoneWeight(animationEvent.FloatData);

            //Same as linq but as a foreach
            foreach (IBoneMark mark in BoneMarks)
            {
                if (string.Equals(mark.BoneId, animationEvent.stringData))
                {
                    mark.SetBoneWeight(animationEvent.FloatData);
                }
            }
        }

        public void StartChekingForTargets(string id)
        {
            BoneMarks.Where(b => string.Equals(b.BoneId, id)).FirstOrDefault().StartLookingForTarget();
        }


        public void StopChekingForTargets(string id)
        {
            BoneMarks.Where(b => string.Equals(b.BoneId, id)).FirstOrDefault().StopLookingForTarget();
        }
    }
}
