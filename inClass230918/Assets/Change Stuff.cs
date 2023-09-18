using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeStuff : MonoBehaviour
{
    public GameObject hairSprite;
    public GameObject shortHair;

    public GameObject whiteShirt;
    public GameObject bowShirt;

    public bool check = true;
    public bool shirtCheck = true;

    public void onClick()
    {
        if(check)
        {
            hairSprite.SetActive(false);
            shortHair.SetActive(true);
            check = !check;
        }
        else 
        {
            hairSprite.SetActive(true);
            shortHair.SetActive(false);
            check = !check;
        }
    }

    public void otherOnClick()
    {
        if(!shirtCheck)
        {
            whiteShirt.SetActive(false);
            bowShirt.SetActive(true);
            shirtCheck = !shirtCheck;
        }
        else 
        {
            whiteShirt.SetActive(true);
            bowShirt.SetActive(false);
            shirtCheck = !shirtCheck;
        }
    }

    public void switchScene()
    {
        SceneManager.LoadScene("Scene 2");
    }
}
