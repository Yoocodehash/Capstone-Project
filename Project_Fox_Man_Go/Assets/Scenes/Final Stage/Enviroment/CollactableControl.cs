using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollactableControl : MonoBehaviour
{
    public static int collectableCount;
    public GameObject collectableCountDisplay;

    private void Update()
    {
        collectableCountDisplay.GetComponent<Text>().text = "" + collectableCount;
    }
}
