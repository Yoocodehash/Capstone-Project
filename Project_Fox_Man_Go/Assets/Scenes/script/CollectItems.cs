using System.Collections;
using System.Collections.Generic;
//using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectItems : MonoBehaviour
{

    public int collectables;

    [SerializeField] AudioSource collectSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider Collectable)
    {
        if(Collectable.gameObject.tag == "Collectable")
        {
            Debug.Log("Collectable Collected");
            collectables = collectables + 1;
            Collectable.gameObject.SetActive(false);

            //new
            CollactableControl.collectableCount += 1;

            collectSound.Play();

            //win condition
            if(collectables == 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    //endPanel.setActive(true);


    //endPanel.setActive(false);


}



















/*

using System.Collections;
using System.Collections.Generic;
//using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectItems : MonoBehaviour
{

    public int collectables;
    //public int cherries;
    //public int strawberries;

    //public MenuController menuController;
    //public TextMeshProUGUI countText;


    //public MenuManager menuManager;
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

            //win condition
            if(collectables == 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            //SetCountText();

        }

    }





// Update is called once per frame
void Update()
{

}





   

     







}

 */











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



/*
void SetCountText()
{
countText.text = "Count: " + countText.ToString();
//countText.text = "Count: " + count.ToString();
if (count >= 2)
   //if (count >= 12)
   {
   //winTextObject.SetActive(true);
   menuManager.WinGame();
   }

}
*/