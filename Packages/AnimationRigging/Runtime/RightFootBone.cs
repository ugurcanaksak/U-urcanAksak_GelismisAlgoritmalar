using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RobotDreams.AnimationRigging
{
    public class RightFootBone : MonoBehaviour, IBoneMark
    {
        public string BoneId => "RightFoot";

        [SerializeField]
        private float SearchRadius;
        private bool isLookingForTarget;

        [SerializeField]
        private GameObject Constrain;

        private IConstrainController constrainController;
        private IConstrainController ConstrainController { get { return constrainController == null ? constrainController = Constrain.GetComponent<IConstrainController>() : constrainController; } }

        public void SetBoneWeight(float weight)
        {
            Debug.Log($"On Bone: {weight}");
            ConstrainController.SetWeight(weight);
        }

        private void Update()
        {
            if (!isLookingForTarget) return;

            SearchForTarget();
        }

        public void StartLookingForTarget()
        {
            isLookingForTarget = true;
        }

        public void StopLookingForTarget()
        {
            isLookingForTarget = false;
        }

        private void SearchForTarget()
        {
            RaycastHit[] hits = Physics.SphereCastAll(transform.position, SearchRadius, transform.forward, 1f);
            Debug.Log($"Targets: {hits.Length}");
            foreach (var hit in hits)
            {
                var target = hit.collider.GetComponent<IAnimationtarget>();
                if (target != null)
                {
                    Debug.Log($"target found: {hit.collider.name}");
                    ConstrainController.AssignTarget(target.t);
                }
            }
        }
    }
}
