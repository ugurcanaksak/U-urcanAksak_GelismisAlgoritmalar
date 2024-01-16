using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.RuntimeUI
{
    public class PanelHorizontalMoveAnimation : PanelAnimationBase
    {
        [SerializeField]
        private Transform _animationTarget;
        [SerializeField]
        private Transform _showTarget;
        [SerializeField]
        private Transform _hideTarget;

        public override void PlayHideAnimation(Action onComplete = null)
        {
            _animationTarget.DOLocalMove(_hideTarget.localPosition, Duration).OnComplete(()=> onComplete.Invoke());
        }

        public override void PlayShowAnimation(Action onComplete = null)
        {
            _animationTarget.DOLocalMove(_showTarget.localPosition, Duration).OnComplete(() => onComplete.Invoke());
        }
    }
}
