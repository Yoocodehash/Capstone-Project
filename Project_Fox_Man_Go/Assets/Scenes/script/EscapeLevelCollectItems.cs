using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeLevelCollectItems : MonoBehaviour
{

    public int collectables;

    [SerializeField] AudioSource collectSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider Collectable)
    {
        if (Collectable.gameObject.tag == "Collectable")
        {
            Debug.Log("Collectable Collected");
            collectables = collectables + 1;
            Collectable.gameObject.SetActive(false);

            //new
            CollactableControl.collectableCount += 1;
            collectSound.Play();

            //win condition
            if (collectables == 113)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
