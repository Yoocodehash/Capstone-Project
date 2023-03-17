using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy_On_Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
/*
 * public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
*/