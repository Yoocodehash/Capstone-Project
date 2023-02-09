/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    public GameObject Player;
    public float Distance;

    public bool isAngered;

    public NavMeshAgent _agent;

    public void Start()
    {

    }

    public void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);

        if (Distance >= 5)
        {
            isAngered = true;
        }

        if (Distance >= 5)
        {
            isAngered = false;
        }

        if (isAngered)
        {
            _agent.SetDestination(Player.transform.position);
        }

        if (isAngered)
        {
            _agent.isStopped = true;


        }

    }

}

*/