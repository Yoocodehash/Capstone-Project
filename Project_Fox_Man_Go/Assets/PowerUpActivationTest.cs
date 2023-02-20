/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpActivationTest : MonoBehaviour
{

    private float activationTime;


    private Color col;
    private float invisible;

    // Start is called before the first frame update
    void Start()
    {

        //invisible = false;

        activationTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        activationTime += Time.deltaTime;

        //col.a = 1;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Invisible")
        {
            invisible = true;
            activationTime = 0;
            //col.a = 0.2;
        }
    }

}

*/