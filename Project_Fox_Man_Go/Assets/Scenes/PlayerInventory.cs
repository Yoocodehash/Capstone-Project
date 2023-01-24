using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfStrawberries { get; private set; }

    //public UnityEvent<PlayerInventory> OnStrawberryCollected;

    public void StrawberryCollected()
    {
        NumberOfStrawberries++;
        //OnStrawberryCollected.Invoke(this);
    }



    /*
    public int NumberOfCherries { get; private set; }
    //public UnityEvent<PlayerInventory> OnCherryCollected;

    public void CherryCollected()
    {
        NumberOfCherries;
        //OnCherryCollected.Invoke(this);
    }
    */



}
