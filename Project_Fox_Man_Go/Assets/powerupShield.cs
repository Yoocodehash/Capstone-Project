using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupShield : MonoBehaviour
{
    public shieldpower shield_orb;
    float Duration = 10f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
            shield_orb.enabled = true;
        }
    }
    IEnumerator Pickup(Collider player)
    {
        //GetComponent<FireBall>().enabled = true;
        GetComponent<SphereCollider>().enabled = false;
        yield return new WaitForSeconds(Duration);
        shield_orb.enabled = false;
        
        Destroy(gameObject);
    }
}
