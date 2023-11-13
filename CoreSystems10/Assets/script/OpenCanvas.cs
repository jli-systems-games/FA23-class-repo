using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenCanvas : MonoBehaviour
{
    public GameObject canvas;

    void OnTriggerEnter2D(Collider2D collider)
    {
        canvas.SetActive(true);
        Debug.Log("sdfsdf");
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        canvas.SetActive(false);
    }
}
