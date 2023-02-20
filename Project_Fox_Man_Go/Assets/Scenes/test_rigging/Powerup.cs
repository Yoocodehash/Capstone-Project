using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public FireBall fire_orb;
    public IceBall ice_orb;



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
             fire_orb.enabled = true;
            // ice_orb.enabled = true;
            // comment out 1 of them for the other to play they can't play at the same time.
        }

        /*
        //not working don't know why
        if (fire_orb.enabled == true)
        {
            ice_orb.enabled = false;
        }

        if (ice_orb.enabled == true)
        {
            fire_orb.enabled = false;
        }
        */
    }

    void Pickup(Collider player)
    {
        Destroy(gameObject);
    }
}
