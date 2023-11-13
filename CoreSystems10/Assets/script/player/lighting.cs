using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class lighting : MonoBehaviour
{
    // Start is called before the first frame update
    public Light2D l;
    public double innerRadiusRange;

    private double innerRadius;
    private double innerRadiusMin;
    private double innerRadiusMax;
    private double innerRadiusChange = 0.02;

    private double falloff; 
    void Start()
    {
        l = GetComponent<Light2D>();
        innerRadius = l.intensity;
        innerRadiusMin = innerRadius - innerRadiusRange;
        innerRadiusMax = innerRadius + innerRadiusRange;
        //Debug.Log(innerRadius);
    }

    // Update is called once per frame
    void Update()
    {
        if(innerRadius > innerRadiusMax || innerRadius < innerRadiusMin){
            innerRadiusChange *= -1;
        }
        else if(Random.Range(0, 10) < 1){
            innerRadiusChange *= -1;
        }
        innerRadius += innerRadiusChange;
        l.intensity = (float) innerRadius;
        //Debug.Log(innerRadius);

    }
}
