using CHARK.ScriptableEvents.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.ScriptableObjectPattern
{
    public class ExampleButton : MonoBehaviour
    {
        public SimpleScriptableEvent CharacterMovementToggledEvent;

        public void TriggerCharacterMovementEvent()
        {
            CharacterMovementToggledEvent.Raise();
        }
    }
}
