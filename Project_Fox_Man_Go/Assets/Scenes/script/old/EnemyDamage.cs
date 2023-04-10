using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        Healthbar.health -= 10f;
    }

}

