using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySelect : MonoBehaviour
{
    public static string selected;
    public GameObject selectBox;
    public GameObject[] otherBoxes;

    public void Start()
    {
        selected = "";
    }
    public void Select()
    {
        Debug.Log("Selected");
        Sprite check= gameObject.GetComponent<SpriteRenderer>().sprite;
        
        if (check != null)
        {
            selected = check.name;
            Debug.Log(selected+" selected");
            foreach (GameObject box in otherBoxes)
            {
                box.SetActive(false);
            }
            selectBox.SetActive(true);
        }
        
    }
}
