using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBall : MonoBehaviour
{
    public Transform projectilePoint;
    public GameObject iceballprefab;
    public float iceballspeed = 10;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var magic = Instantiate(iceballprefab, projectilePoint.position, projectilePoint.rotation);
            magic.GetComponent<Rigidbody>().velocity = projectilePoint.forward * iceballspeed;
        }
    }
}
