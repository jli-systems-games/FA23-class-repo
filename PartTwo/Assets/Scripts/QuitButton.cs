using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{

    public Button quitButton;

    private void Start()
    {

        quitButton.onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
