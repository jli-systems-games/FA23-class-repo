using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aspectRatio : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1440, 1080, FullScreenMode.ExclusiveFullScreen, new RefreshRate() { numerator = 24, denominator = 1 });
    }
}
