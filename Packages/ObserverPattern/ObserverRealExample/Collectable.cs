using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RobotDreams.ObserverPattern.CharacterExample
{
    public class Collectable : MonoBehaviour
    {

        public int CollectableValue;

        public void Collect()
        {
            EventManager.OnCollectableCollected.Invoke(CollectableValue);
            Debug.Log("CollectableCollected");
            Destroy(gameObject);
        }
    }
}
