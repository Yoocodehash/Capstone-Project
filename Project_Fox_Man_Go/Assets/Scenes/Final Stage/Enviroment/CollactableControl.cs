using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollactableControl : MonoBehaviour
{
    public static int collectableCount;
    public GameObject collectableCountDisplay;
    public GameObject collectableEndDisplay;

    private void Start()
    {
        collectableCount = 0;
    }

    private void Update()
    {
        collectableCountDisplay.GetComponent<Text>().text = "" + collectableCount;
        collectableEndDisplay.GetComponent<Text>().text = "" + collectableCount;
    }
}
