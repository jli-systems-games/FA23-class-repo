using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class MikaelExpression : MonoBehaviour
{
    public GameObject mExpression;

    public Sprite[] mExpressionArray;

    public Image mExpressioSprite;
    public void Start()
    {
        mExpressioSprite = mExpression.GetComponent<Image>();

    }
    [YarnCommand("expr_mikael")]
    public void LExpression(string expression)
    {
        for (int i = 0; i < mExpressionArray.Length; i++)
        {
            if (mExpressionArray[i].name == expression)
            {
                mExpressioSprite.sprite = mExpressionArray[i];
            }
        }
    }
}
