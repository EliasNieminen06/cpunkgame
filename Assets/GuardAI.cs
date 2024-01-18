using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    public NavMeshAgent guard;
    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        newPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == targetPosition)
        {
            newPosition();
        }
        guard.SetDestination(targetPosition);
        
    }

    // Get new position
    void newPosition()
    {
        float positionX = Random.Range(-5, 5);
        float positionZ = Random.Range(-5, 5);
        Vector3 randomPoint = new Vector3(positionX, 1.5f, positionZ);
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
        {
            targetPosition = new Vector3(positionX, transform.position.y, positionZ);
        }
        else
        {
            newPosition();
        }
    }
}
