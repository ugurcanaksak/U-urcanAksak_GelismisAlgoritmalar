using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RobotDreams.ObserverPattern
{
    public class EnemyData
    {
        int ifoo;
        float ffoo;
    }

    public static class EventManager
    {
        public static UnityEvent<int> OnPlayerKilled;
    }
}
