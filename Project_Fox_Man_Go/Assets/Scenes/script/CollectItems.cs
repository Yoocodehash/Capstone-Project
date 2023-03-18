using System.Collections;
using System.Collections.Generic;
//using TMPro;
using UnityEngine;

public class CollectItems : MonoBehaviour
{

    public int collectables;
    //public int cherries;
    //public int strawberries;


    //public MenuController menuController;

    //public TextMeshProUGUI countText;



    [SerializeField] AudioSource collectSound;

    // Start is called before the first frame update
    void Start()
    {
        //SetCountText();
        //winTextObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider Collectable)
    {
        if(Collectable.gameObject.tag == "Collectable")
        {
            Debug.Log("Collectable Collected");
            collectables = collectables + 1;
            Collectable.gameObject.SetActive(false);
            //Destroy(Collectable.gameObject);

            //new
            CollactableControl.collectableCount += 1;
           // this.gameObject.SetActive(false);
            //
            collectSound.Play();

            //SetCountText();

        }

    }

    /*
    public void OnTriggerEnter(Collider Cherry)
    {
        if (Cherry.gameObject.tag == "Cherry")
        {
            Debug.Log("Cherry Collected");
            cherries = cherries + 1;
            Cherry.gameObject.SetActive(false);
            //Destroy(Cherry.gameObject);
        }
    }
    */


    /*
        public void OnTriggerEnter(Collider Strawberry)
    {
        if(Strawberry.gameObject.tag == "Strawberry")
        {
            Debug.Log("Strawberry Collected");
            strawberries = collectables + 1;
            Strawberry.gameObject.SetActive(false);
            //Destroy(Strawberry.gameObject);

            collectSound.Play();

        }

    }
    */




    // Update is called once per frame
    void Update()
{

}





    /*
     
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
            if(count >= 12)
            {
                //winTextObject.SetActive(true);
                menuController.WinGame();
            }

     }


     */







}
