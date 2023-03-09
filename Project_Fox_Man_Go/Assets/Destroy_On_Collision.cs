using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_On_Collision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
