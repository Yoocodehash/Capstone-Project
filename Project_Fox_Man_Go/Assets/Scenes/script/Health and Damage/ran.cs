/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ran : MonoBehaviour
{

    public float Health;

    public Slider HealthBar;

    private void Start()
    {

        HealthBar.value = Health;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.Equals(6))
        {
            IsGrounded = true;
        }

        if (collision.gameObject.layer.Equals(7))
        {
            //Health = Health -10; 
            Health -= 10;
        }



    }

}

*/