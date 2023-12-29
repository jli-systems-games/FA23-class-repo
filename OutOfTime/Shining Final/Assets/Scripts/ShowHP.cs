using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowHP : MonoBehaviour
{
    /*    public TextMeshProUGUI textMeshPro;
        public GameObject otherObject;
        public string variableName;

        private void Update()
        {
            if (otherObject != null)
            {
                if (otherObject.TryGetComponent(out MonoBehaviour otherComponent))
                {
                    var variableValue = otherComponent.GetType().GetField(variableName).GetValue(otherComponent);
                    textMeshPro.text = variableValue.ToString();
                }
            }
        }*/

    public TextMeshProUGUI textMeshPro;
    public GameObject otherObject;

    private void Update()
    {
        if (otherObject != null)
        {
            var collisionCount = otherObject.GetComponent<HurtPlayer>().collisionCount;
            textMeshPro.text = collisionCount.ToString();
        }
    }
}
