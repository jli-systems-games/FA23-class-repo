using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class toGameComplete : MonoBehaviour
{
    public static int moneyTotal = 0;
    public GameObject completeScreen;

    public TMP_Text moneyEarnedText;
    public TMP_Text moneyTotalText;
    public TMP_Text bottomline;

    public GameObject scriptHolder;
    public goldCalclator thescript;

    void Start()
    {
        thescript = scriptHolder.GetComponent<goldCalclator>();
    }

    public void switchToGameComplete()
    {
        completeScreen.SetActive(true);
    }

    public void updateMoney()
    {
        //Debug.Log("running");
        if (thescript.totalgold>moneyTotal)
        {
            moneyTotal = thescript.totalgold;
        }
        moneyEarnedText.text = " " + thescript.totalgold;
        moneyTotalText.text = " " + moneyTotal;

        if(thescript.totalgold<-100)
        {
            bottomline.text = "Forget the aliens. How did you score this";
        }

        else if (thescript.totalgold<25 && thescript.totalgold>=-100)
        {
            bottomline.text = "Your work was so bad. The aliens killed you.";
        }
        else if (thescript.totalgold>=25 && thescript.totalgold<35)
        {
            bottomline.text = "The aliens have spared you... for now.";
        }
        else if (thescript.totalgold>=35)
        {
            bottomline.text = "The aliens were impressed and promoted you.";
        }
    }
}
