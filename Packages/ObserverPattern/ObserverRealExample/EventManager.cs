using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RobotDreams.ObserverPattern.CharacterExample
{
    public static class EventManager 
    {
        public static UnityEvent<int> OnCollectableCollected = new UnityEvent<int>();
        public static UnityEvent<int> OnScoreUpdated = new UnityEvent<int>();
    }
}
