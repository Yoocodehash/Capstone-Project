using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldpower : MonoBehaviour
{
    public GameObject playershield;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       playershield.SetActive(true);
    }
}
