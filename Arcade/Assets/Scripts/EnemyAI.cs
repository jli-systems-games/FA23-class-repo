using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform[] patrolPoints; 
    public float patrolSpeed = 2.0f;
    public float chaseSpeed = 4.0f;
    public float patrolWaitTime = 2.0f;
    public float playerDetectionRadius = 5.0f;
    public float attackRadius = 1.0f;
    public float attackCooldown = 2.0f;

    private NavMeshAgent navMeshAgent;
    private Transform player;
    private int currentPatrolIndex;
    private float patrolTimer;
    private float attackTimer;

    public Animator animator;

    public int damageAmount = 10;

    private enum EnemyState
    {
        Patrol,
        Chase,
        Attack
    }

    private EnemyState currentState;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform; 

        SetNextPatrolPoint();
        currentState = EnemyState.Patrol;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        switch (currentState)
        {
            case EnemyState.Patrol:
                Patrol();
                if (distanceToPlayer < playerDetectionRadius)
                {
                    currentState = EnemyState.Chase;
                }
                break;

            case EnemyState.Chase:
                Chase();
                if (distanceToPlayer < attackRadius)
                {
                    currentState = EnemyState.Attack;
                }
                else if (distanceToPlayer > playerDetectionRadius)
                {
                    currentState = EnemyState.Patrol;
                }
                break;

            case EnemyState.Attack:
                Attack();
                if (distanceToPlayer > attackRadius)
                {
                    currentState = EnemyState.Chase;
                }
                break;
        }
    }

    void Patrol()
    {
        navMeshAgent.speed = patrolSpeed;

        if (navMeshAgent.remainingDistance < 0.5f)
        {
            patrolTimer += Time.deltaTime;

            if (patrolTimer >= patrolWaitTime)
            {
                SetNextPatrolPoint();
                patrolTimer = 0f;
            }
        }
    }

    void SetNextPatrolPoint()
    {
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        navMeshAgent.SetDestination(patrolPoints[currentPatrolIndex].position);
    }

    void Chase()
    {
        navMeshAgent.speed = chaseSpeed;
        navMeshAgent.SetDestination(player.position);
    }

    void Attack()
    {
        
        animator.SetTrigger("MeleeAttack");
        if (Time.time >= attackTimer)
        {
            DealDamageToPlayer();

            
            attackTimer = Time.time + attackCooldown;
        }
    }

    void DealDamageToPlayer()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer <= attackRadius)
        {

            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
            }
        }
    }
}
