using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class FireBall : MonoBehaviour
{
   public Transform projectilePoint;
   public GameObject fireballprefab;
   public float fireballspeed = 10;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var magic = Instantiate(fireballprefab, projectilePoint.position, projectilePoint.rotation);
            magic.GetComponent<Rigidbody>().velocity = projectilePoint.forward * fireballspeed;

        }
    }
}
