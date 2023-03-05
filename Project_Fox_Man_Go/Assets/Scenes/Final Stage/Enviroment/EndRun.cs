using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRun : MonoBehaviour
{
    public GameObject liveCollectable;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject fadeOut;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(5);
        liveCollectable.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
    }
}
