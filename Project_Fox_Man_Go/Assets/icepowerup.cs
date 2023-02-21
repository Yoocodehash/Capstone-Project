using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icepowerup : MonoBehaviour
{
    public IceBall ice_orb;
    float Duration = 4f;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            //Pickup(other);
            StartCoroutine(Pickup(other));
            ice_orb.enabled = true;


        }
    }

    IEnumerator Pickup(Collider player)
    {
        //GetComponent<FireBall>().enabled = true;
        GetComponent<SphereCollider>().enabled = false;
        yield return new WaitForSeconds(Duration);
        ice_orb.enabled = false;
        Destroy(gameObject);
    }
}
