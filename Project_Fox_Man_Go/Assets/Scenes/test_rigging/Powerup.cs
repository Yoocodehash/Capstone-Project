using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public FireBall fire_orb;
    float Duration = 4f;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            //Pickup(other);
            StartCoroutine(Pickup(other));
            fire_orb.enabled = true;

            
        }
    }

    IEnumerator Pickup(Collider player)
    {
        //GetComponent<FireBall>().enabled = true;
        GetComponent<SphereCollider>().enabled = false;
        yield return new WaitForSeconds(Duration);
        fire_orb.enabled = false;

        Destroy(gameObject);
    }

}
