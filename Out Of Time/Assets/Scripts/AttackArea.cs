using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public PlayerAttack playerAttack;
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy"&& playerAttack.attacking)
        {
            Debug.Log("Attacking");
            
            Destroy(collision.gameObject,0.1f);

        }
    }

    
}
