using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrol : MonoBehaviour
{
    public Transform[] patrolPoints; 

    private int currentPatrolIndex;
    private Transform currentTarget;
    public float speed = 2.0f;

    void Start()
    {
        if (patrolPoints.Length < 3)
        {
            Debug.LogError("Please assign at least three patrol points in the Inspector.");
            enabled = false;
            return;
        }

        
        currentPatrolIndex = Random.Range(0, patrolPoints.Length);
        currentTarget = patrolPoints[currentPatrolIndex];
    }

    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

       
        if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            
            GetNextPatrolPoint();
        }
    }

    void GetNextPatrolPoint()
    {
        int previousIndex = currentPatrolIndex;

        
        do
        {
            currentPatrolIndex = Random.Range(0, patrolPoints.Length);
        } while (currentPatrolIndex == previousIndex);

        currentTarget = patrolPoints[currentPatrolIndex];
    }
}
