using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    private bool Selected1 = false;
    private bool Selected2 = false;
    private bool Selected3 = false;

    public TextMeshProUGUI displayText;

    public void Hover1()
    {
        displayText.text = "The three friends meet at the park.";
    }

    public void Hover2()
    {
        displayText.text = "Middle school was a dark time for everyone.";
    }

    public void Hover3()
    {
        displayText.text = "Shit hits the fan at a party.";
    }

    public void UnHover()
    {
        if (!Selected1 && !Selected2 && !Selected3)
        {
            displayText.text = "Please select a level to continue.";
        }
    }

    public void Select1()
    {
        Selected1 = true;
        Selected2 = false;
        Selected3 = false;
        displayText.text = "The three friends meet at the park.";

    }

    public void Select2()
    {
        Selected2 = true;
        Selected1 = false;
        Selected3 = false;
        displayText.text = "Middle school was a dark time for everyone.";

    }

    public void Select3()
    {
        Selected3 = true;
        Selected1 = false;
        Selected2 = false;
        displayText.text = "Shit hits the fan at a party.";

    }


    public void PlayButton()
    {
        SceneManager.LoadScene("Childhood");
    }
}
