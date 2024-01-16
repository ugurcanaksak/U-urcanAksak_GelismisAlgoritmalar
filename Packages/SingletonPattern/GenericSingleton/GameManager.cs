using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotDreams.SingletonPattern.GenericSingleton
{
    public class GameManager : Singleton<GameManager>
    {
        public void StarGame()
        {
            Debug.Log("Game Started");
        }
    }
}
