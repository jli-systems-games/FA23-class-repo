using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitText : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator textAnimation;

    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        textAnimation.SetTrigger("Done");
    }
}
