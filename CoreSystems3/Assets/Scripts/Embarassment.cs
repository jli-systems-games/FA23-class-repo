using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Embarassment : MonoBehaviour
{
    public int embarassCounter;
    public GameObject player;
    public GameObject endScreen;

    public int maximum;

    public Slider slider;

    public void setHealth()
    {
        slider.value = maximum - embarassCounter;
    }

    public void counterAdd()
    {
        embarassCounter++;
        setHealth();
        StartCoroutine(checkCounter());
    }

    private IEnumerator checkCounter()
    {
        WaitForSeconds wait = new WaitForSeconds(0.5f);

        while (true)
        {
            if (embarassCounter >= 30)
            {
                endScreenUp();
            }
            yield return wait;
            
        }
    }

    public void endScreenUp()
    {
        endScreen.SetActive(true);
    }
}
