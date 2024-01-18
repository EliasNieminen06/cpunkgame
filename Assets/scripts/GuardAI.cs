using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour
{
    public NavMeshAgent guard;
    public Vector3 targetPosition;
    public bool follow = false;
    public Transform player;
    bool cooldownstarted = false;

    // Start is called before the first frame update
    void Start()
    {
        newPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (!follow)
        {
            guard.speed = 2;
            if (transform.position == targetPosition)
            {
                newPosition();
            }
        }
        else
        {
            guard.speed = 6;
            targetPosition = new Vector3(player.position.x, 1.5f, player.position.z);
            if (!cooldownstarted)
            {
                StartCoroutine(stopfollow());
            }
        }
        guard.SetDestination(targetPosition);
    }

    // Get new position
    void newPosition()
    {
        float positionX = Random.Range(2, 13);
        float positionZ = Random.Range(2, 13);
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

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            follow = true;
            StopCoroutine(stopfollow());
            cooldownstarted = false;
        }
    }

    IEnumerator stopfollow()
    {
        cooldownstarted = true;
        yield return new WaitForSeconds(5);
        follow = false;
        cooldownstarted = false;
    }
}
