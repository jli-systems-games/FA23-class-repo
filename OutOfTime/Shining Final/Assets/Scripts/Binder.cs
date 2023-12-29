using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binder : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    void Start()
    {
        // Set the parent of all objects to this GameObject
        SetParentForObject(object1);
        SetParentForObject(object2);
        SetParentForObject(object3);
    }

    void SetParentForObject(GameObject obj)
    {
        if (obj != null)
        {
            obj.transform.SetParent(transform);
        }
    }

    void Update()
    {
        // Example: Check for the G key press to toggle the objects
        if (Input.GetKeyDown(KeyCode.G))
        {
            ToggleObjects();
        }
    }

    void ToggleObjects()
    {
        // Example: Toggle the objects between active and inactive
        object1.SetActive(!object1.activeSelf);
        object2.SetActive(!object2.activeSelf);
        object3.SetActive(!object3.activeSelf);
    }
}
