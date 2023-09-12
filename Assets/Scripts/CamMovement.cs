using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;


public class CamMovement : MonoBehaviour
{

    public GameObject spawner;

    public void MoveCamera()
    {
        Camera.main.transform.Translate(0, 5, 0);
        spawner.transform.Translate(0, 5, 0);
    }
}