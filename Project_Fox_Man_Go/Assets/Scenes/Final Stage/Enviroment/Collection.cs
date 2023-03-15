using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{

    //CollectableScoreManager collectableScoreManager;

    public AudioSource soundFX;

    private void Start()
    {
        //collectableScoreManager = GameObject.Find("Canvas").GetComponent<CollectableScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        soundFX.Play();
        //collectableScoreManager.IncreaseScore();
        CollactableControl.collectableCount += 1;
        this.gameObject.SetActive(false);
    }
}
