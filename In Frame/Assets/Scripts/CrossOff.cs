using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrossOff : MonoBehaviour
{
    public TextMeshProUGUI birdList;
    public TextMeshProUGUI mushroomList;
    public TextMeshProUGUI flowerList;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InCameraDetector.bird==true)
        {
            birdList.text = "<s>bird</s>";
        }
        if (InCameraDetector.mushroom == true)
        {
            mushroomList.text = "<s>mushroom,</s>";
        }
        if (InCameraDetector.flower == true)
        {
            flowerList.text = "<s>flower,</s>";
        }

    }
}
