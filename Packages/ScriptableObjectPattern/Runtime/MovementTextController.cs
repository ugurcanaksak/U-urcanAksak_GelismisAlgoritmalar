using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotDreams.ScriptableObjectPattern
{
    public class MovementTextController : MonoBehaviour
    {
        private Text text;
        private Text MovementText { get { return text == null ? text = GetComponent<Text>() : text; } }

        public void UpdateText()
        {
            StartCoroutine(UpdateTextCo());
        }

        private IEnumerator UpdateTextCo()
        {

            MovementText.text = "MovementChanged";
            yield return new WaitForSeconds(3);
            MovementText.text = "";

        }
    }
}
