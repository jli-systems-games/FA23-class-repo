using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public GameObject feature;
    public Transform pose;
    public float adjValue;
    void Start()
    {
        pose = feature.transform;
        
    }

    public void Up()
    {
        pose.position = transform.position + new Vector3(0f, adjValue, 0f);
    }
    public void Down()
    {
        pose.position = transform.position + new Vector3(0f, -adjValue, 0f);
    }
    public void Left()
    {
        pose.position = transform.position + new Vector3(-adjValue, 0f, 0f);
    }
    public void Right()
    {
        pose.position = transform.position + new Vector3(adjValue, 0f, 0f);
    }
}
