using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DelayDestroy : MonoBehaviour
{
    public float _seconds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObjectDestroy());
    }

    public IEnumerator ObjectDestroy()
    {
        yield return new WaitForSeconds(_seconds);
        Destroy(gameObject);
    }
}
