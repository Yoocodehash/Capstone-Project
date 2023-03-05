using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CountSequence());    
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        PlayerMove.canMove = true;
    }
}
