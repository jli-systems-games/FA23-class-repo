using Hertzole.GoldPlayer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TodoList : MonoBehaviour
{
    public GameObject list;
    public bool visible;
    public GoldPlayerController moveScript;

    public void Start()
    {
        list.SetActive(true);
        visible = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Pressed");
            visible = !visible;
            list.SetActive(visible);
        }

        if (visible)
        {
            moveScript.enabled=false;
        }
        else
        {
            moveScript.enabled = true;
        }
    }
}
