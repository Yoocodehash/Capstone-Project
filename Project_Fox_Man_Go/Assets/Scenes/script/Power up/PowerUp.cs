/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    //public float multiplier = 1.4f;

    //public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            PickUp();

            //PickUp(other);

        }

    }


    void PickUp(Collider player)

    void PickUp()
    {

        //Instantiate(pickupEffect, transform.position, transform.rotation);

        //player.transform.localscale *= multiplier;

        Debug.Log("The power up has been picked up");

        Destroy(gameObject);
    }

}

*/