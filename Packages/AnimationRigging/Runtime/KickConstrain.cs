using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using static UnityEngine.GraphicsBuffer;

namespace RobotDreams.AnimationRigging
{
    public class KickConstrain : MonoBehaviour, IConstrainController
    {
        private TwoBoneIKConstraint constrain;
        private TwoBoneIKConstraint Constrain {  get { return constrain == null ? constrain = GetComponent<TwoBoneIKConstraint>() : constrain; } }

        private RigBuilder rigBuilder;
        private RigBuilder RigBuilder { get { return rigBuilder == null ? rigBuilder = transform.root.GetComponent<RigBuilder>() : rigBuilder; } }

        private float currentWeight;
        private Transform currentTarget;

        public void AssignTarget(Transform target)
        {
            currentTarget = target;
            Constrain.data.target = currentTarget;
            RigBuilder.Build();
        }

        public void SetWeight(float weight)
        {
            currentWeight = weight;
            Constrain.weight = currentWeight;
            RigBuilder.Build();
        }

        private void Update()
        {
            Constrain.weight = currentWeight;
            //Constrain.data.target = currentTarget;
        }
    }
}
