using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene1 : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("1");
    }
}
