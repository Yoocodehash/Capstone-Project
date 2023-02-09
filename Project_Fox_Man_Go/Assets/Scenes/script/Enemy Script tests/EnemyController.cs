using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public Transform playerObj;
    protected NavMeshAgent enemyMesh;

    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        enemyMesh.SetDestination(playerObj.position);
    }

}
