using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform[] patrolPoints; 
    public float moveSpeed = 5f;     
    private int currentPointIndex = 0; 

    void Update()
    {
       
        if (Vector3.Distance(transform.position, patrolPoints[currentPointIndex].position) < 0.2f)
        {
            
            currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
        }

       
        Vector3 direction = (patrolPoints[currentPointIndex].position - transform.position).normalized;

      
        if (Vector3.Dot(transform.forward, direction) < 0)
        {
            direction = -direction;
        }

       
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, moveSpeed * Time.deltaTime);

        
        if (direction != Vector3.zero)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f);
        }
    }
}
