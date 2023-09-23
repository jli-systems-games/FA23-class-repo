using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class LilithExpression : MonoBehaviour
{
    public GameObject lExpression;

    public Sprite[] lExpressionArray;

    public Image lExpressionSprite;
    public void Start()
    {
        lExpressionSprite = lExpression.GetComponent<Image>();

    }
    [YarnCommand("expr_lilith")]
    public void LExpression(string expression)
    {
        for (int i = 0; i < lExpressionArray.Length; i++)
        {
            if (lExpressionArray[i].name == expression)
            {
                lExpressionSprite.sprite = lExpressionArray[i];
            }
        }
    }
  
}
