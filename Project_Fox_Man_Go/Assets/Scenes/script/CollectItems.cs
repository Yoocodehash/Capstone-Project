using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{

    public int strawberries;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Strawberry)
    {
        if(Strawberry.gameObject.tag == "Strawberry")
        {
            Debug.Log("Strawberry Collected");
            strawberries = strawberries + 1;
            Strawberry.gameObject.SetActive(false);
            //Destroy(Strawberry.gameObject);
        }

        /*
            if(Cherry.gameObject.tag == "Cherry")
        {
            Debug.Log("Cherry Collected");
            cherries = cherries + 1;
            Cherry.gameObject.SetActive(false);
            //Destroy(Cherry.gameObject);
        }
         */


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
