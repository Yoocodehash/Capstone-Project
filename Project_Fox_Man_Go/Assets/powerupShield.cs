using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupShield : MonoBehaviour
{
    public shieldpower shield_orb;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
            shield_orb.enabled = true;
            //able to switch powerup so player can choose carefully which powerup they pick
            /*
            if (fire_orb.enabled == true)
            {
                ice_orb.enabled = false;
            }

            if (ice_orb.enabled == true)// or else if?
            {
                fire_orb.enabled = false;
            }
            */
            // comment out 1 of them for the other to play they can't play at the same time.
        }
    }

    void Pickup(Collider player)
    {
        Destroy(gameObject);
    }
}
