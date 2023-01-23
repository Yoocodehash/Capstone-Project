using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public int NumberOfStrawberries { get; private set; }

    public void StrawberryCollected()
    {
        NumberOfStrawberries++;
    }

}
