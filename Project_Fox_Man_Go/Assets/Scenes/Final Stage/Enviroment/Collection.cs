using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public AudioSource soundFX;

    void OnTriggerEnter(Collider other)
    {
        soundFX.Play();
        CollactableControl.collectableCount += 1;
        this.gameObject.SetActive(false);
    }
}
