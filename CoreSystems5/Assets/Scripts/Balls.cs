using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public GameObject hold1;
    public GameObject hold2;

    void Start()
    {
        StartCoroutine(BallsDown());
    }

    IEnumerator BallsDown()
    {
        yield return new WaitForSeconds(10f);
        GameObject.Destroy(hold1);
        yield return new WaitForSeconds(10f);
        GameObject.Destroy(hold2);
    }
}
