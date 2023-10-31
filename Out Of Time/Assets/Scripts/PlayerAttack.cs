using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackArea;
    public GameObject attackAreaUp;
    public GameObject attackAreaDown;
    public bool attacking = false;
    private float timeToAttack = 1f;
    private float timer = 0f;
    public CharaMovement moveScript;
    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Attack();
        }

        if (attacking)
        {
            timer += Time.deltaTime;
            if (timer >= timeToAttack)
            {
                timer = 0f;
                attacking = false;
                //attackArea.SetActive(attacking);
               /* attackAreaUp.SetActive(attacking);
                attackAreaDown.SetActive(attacking);*/
            }
        }
    }

    private void Attack()
    {
        /*if (moveScript.up)
        {
            animator.SetTrigger("AttackUp");
            attackAreaUp.SetActive(attacking);
            attacking = true;
            Debug.Log("AttackingUp");
        }
        else if (moveScript.down)
        {
            animator.SetTrigger("AttackDown");
            attackAreaDown.SetActive(attacking);
            attacking = true;
            Debug.Log("AttackingDown");
        }
        else
        {*/
            animator.SetTrigger("Attack");
            //attackArea.SetActive(attacking);
            attacking = true;
            
        //}

    }
}
