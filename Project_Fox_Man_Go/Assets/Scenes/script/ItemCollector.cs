using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int strawberries = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Strawberry"))
        {
            Destroy(other.gameObject);
            strawberries++;
            Debug.Log("Strawberries: " + strawberries);
        }

    }

}
