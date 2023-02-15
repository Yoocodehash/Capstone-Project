/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    private Transform Player;
    private float distance;
    public float moveSpeed;
    public float howClose;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);

        if (distance <= howclose)
        {
            transform.LookAt(player);
            GetComponent<RigidBody>().AddForce(transform.forward * moveSpeed);
        }

        //For attack
        if (distance <= 1.5f)
        {
            //Do damage
        }


    }

}

*/