using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 2f;
    public float radius = 2f;
    private float angle = 0f;
    private Vector2 center;

    private void Start()
    {
        center = transform.position;
    }

    private void Update()
    {
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;
        transform.position = center + new Vector2(x, y);
    }
}
