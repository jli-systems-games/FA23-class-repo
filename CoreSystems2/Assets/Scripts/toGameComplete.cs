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
        moneyTotal = moneyTotal + thescript.totalgold;
        moneyEarnedText.text = " " + thescript.totalgold;
        moneyTotalText.text = " " + moneyTotal;
    }
}
