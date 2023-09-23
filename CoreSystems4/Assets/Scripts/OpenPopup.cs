using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPopup : MonoBehaviour
{
    public GameObject popup;

    public void onClick()
    {
        popup.SetActive(true);
    }
}
