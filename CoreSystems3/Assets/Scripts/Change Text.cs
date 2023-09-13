using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{

    public TMP_Text text;
    public int counter = 0;
    public GameObject theButton;

    public void textBoxClicked()
    {
        switch(counter)
        {
            case 3:
                GameObject.Destroy(theButton);
                GameObject.Destroy(text);
                break;
            case 2:
                text.text = "I needa get out of here...";
                counter++;
                break;
            case 1:
                text.text = "...!!!";
                counter++;
                break;
            case 0:
                text.text = "Romeo... GET UP! NOW!";
                counter++;
                break;
            default:
                break;
        }
    }
}
