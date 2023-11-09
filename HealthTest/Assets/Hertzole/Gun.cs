using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public GameObject thePlayer;


    private void OnTriggerEnter(Collider other)
    {
        Target target = thePlayer.GetComponent<Target>();
        if (target!=null)
        {
            target.TakeDamage(damage);
        }
    }
}
