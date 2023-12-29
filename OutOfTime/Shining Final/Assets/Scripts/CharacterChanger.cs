using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    private int activeObjectIndex = 0;

    void Start()
    {
        // Initially, activate the first object and deactivate the others
        ActivateObject(object1);
        DeactivateObject(object2);
        DeactivateObject(object3);
    }

    void Update()
    {
        // Check for the C key press
        /*if (Input.GetKeyDown(KeyCode.C))
        {
            // Toggle to the next object
            ToggleObject();
        }*/
    }

    void ToggleObject()
    {
        // Deactivate the currently active object
        DeactivateCurrentObject();

        // Move to the next object in the sequence
        activeObjectIndex = (activeObjectIndex + 1) % 3;

        // Activate the new object
        ActivateCurrentObject();
    }

    void ActivateObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    void DeactivateObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    void ActivateCurrentObject()
    {
        switch (activeObjectIndex)
        {
            case 0:
                ActivateObject(object1);
                break;
            case 1:
                ActivateObject(object2);
                break;
            case 2:
                ActivateObject(object3);
                break;
        }
    }

    void DeactivateCurrentObject()
    {
        switch (activeObjectIndex)
        {
            case 0:
                DeactivateObject(object1);
                break;
            case 1:
                DeactivateObject(object2);
                break;
            case 2:
                DeactivateObject(object3);
                break;
        }
    }
}
