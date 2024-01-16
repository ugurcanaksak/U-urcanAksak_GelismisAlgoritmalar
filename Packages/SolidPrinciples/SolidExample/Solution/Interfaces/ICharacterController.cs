using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SolidExample
{
    public interface ICharacterController
    {
        void Move(Vector2 direction);
        void Jump(float jumpPower);
        void StepBack(Vector2 step);
        bool GroundCheck();
    }
}
