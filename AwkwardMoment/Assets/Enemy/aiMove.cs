using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aiMove : MonoBehaviour
{
    public GameObject stalkerDest;
    NavMeshAgent stalkerAgent;

    private void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        stalkerAgent.SetDestination(stalkerDest.transform.position);
    }
}
