using UnityEngine;

namespace RobotDreams.SolidPrinciples.Homework.Liscow
{
    public class Player : MonoBehaviour
    {
        public string playerName;
        public int playerScore;

        public void SetName(string name)
        {
            playerName = name;
        }

        public void SetScore(int score)
        {
            playerScore = score;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward);
            if (Input.GetKey(KeyCode.S))
                transform.Translate(-Vector3.forward);
            if (Input.GetKey(KeyCode.A))
                transform.Translate(-Vector3.right);
            if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector3.right);
        }
    }
}

