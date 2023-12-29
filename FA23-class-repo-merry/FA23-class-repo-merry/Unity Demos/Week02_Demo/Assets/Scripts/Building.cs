using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public int autoIncriment = 1;
    public int buildingCount = 0;
    public int cost = 10;

    public bool canBuy;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PassiveIncome", 0f, 1f);
        canBuy = false;

        btn = GetComponent<Button>();
        btn.interactable = false;
        
    }

    void PassiveIncome()
    {
        GameManager.ScoreIncreased?.Invoke(autoIncriment);
    }

    public void AddBuilding()
    {
        if (canBuy == true) 
        { 
            buildingCount++;
            autoIncriment = (autoIncriment + 1) + 2;
            GameManager.score -= cost;

            GameManager.ScoreIncreased?.Invoke(0);
            cost += 4;
            CanBuyBuilding(false);
        }
    }

    public void CanBuyBuilding(bool x)
    {
        canBuy = x;
        btn.interactable = x;
    }
}
