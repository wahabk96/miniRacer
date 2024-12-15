/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{



    private NavMeshAgent navMeshAgent;

    public Transform target; // Set this to the destination where the AI car should move

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (target != null)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }

    void SetDestination()
    {
        navMeshAgent.SetDestination(target.position);
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Transform[] targets; // Array of targets for the AI car to move between
    private int currentTargetIndex = 0; // Index of the current target

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (targets.Length > 0)
        {
            SetDestinationToNextTarget();
        }
    }

    void SetDestinationToNextTarget()
    {
        // Set the destination to the current target
        navMeshAgent.SetDestination(targets[currentTargetIndex].position);
    }

    void Update()
    {
        // Check if the car has reached the current target
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            // Move to the next target
            currentTargetIndex = (currentTargetIndex + 1) % targets.Length;
            SetDestinationToNextTarget();
        }
    }
}
