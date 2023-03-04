using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHealth : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Health.health -= 10f;
    }

}
