using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toShop : MonoBehaviour
{
   public void switchToShop()
    {
        SceneManager.LoadScene("MainScreen");
    }
}
