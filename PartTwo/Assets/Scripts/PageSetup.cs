using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PageSetup : MonoBehaviour
{
    public Client amber;
    public Client kris;
    public static Client picked;

    public TextMeshProUGUI nameText;
    public Image icon;
    public Image pfpFrame;
    public TextMeshProUGUI currentConcern;
    public TextMeshProUGUI feeling;

    public void Update()
    {
        if (ClientPick.picked)
        {
            if (ClientPick.amberPick)
            {
                picked = amber;
            }
            else if (ClientPick.krisPick)
            {
                picked = kris;
            }

            nameText.text = picked.nameTitle;
            icon.color = picked.color;
            pfpFrame.color=picked.color;
            currentConcern.text = picked.currentConcern;
            feeling.text=picked.feeling;
        }
    }



}
