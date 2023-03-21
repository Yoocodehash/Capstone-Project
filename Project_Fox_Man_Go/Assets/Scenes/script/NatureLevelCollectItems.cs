using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NatureLevelCollectItems : MonoBehaviour
{

    public int collectables;

    [SerializeField] AudioSource collectSound;

    public GameObject winMenu;

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
            if (collectables == 207)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                winMenu.SetActive(true);
            }

        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
