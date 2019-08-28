using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public Transform target;
    public GameObject explosion;
    private void Start()
    {

        navAgent.SetDestination(GameManager.gameManager.target.position);
    }

    public void EnemyDeath()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
