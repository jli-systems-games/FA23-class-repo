using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToStart : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Childhood");
    }
}
