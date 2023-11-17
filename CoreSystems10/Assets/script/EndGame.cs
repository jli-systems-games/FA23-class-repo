using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Light2D light;
    public bool isGo;

    public float inc;

    public void OnTriggerEnter2D()
    {
        isGo = true;
    }   

    void Update()
    {
        if (isGo)
        {
            light.intensity += inc;
            light.pointLightOuterRadius += inc;
            //light.pointLightInnerRadius += inc;
        }

        if (light.intensity >= 170)
        {
            SceneManager.LoadScene("End");
        }
    }
}
