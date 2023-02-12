/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    //public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            PickUp();
        }

    }

    void PickUp()
    {

        //Instantiate(pickupEffect, transform.position, transform.rotation);

        Debug.Log("The power up has been picked up");

        Destroy(gameObject);
    }

}

*/