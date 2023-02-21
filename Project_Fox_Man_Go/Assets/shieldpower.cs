using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldpower : MonoBehaviour
{
    public GameObject playershield;

    // Start is called before the first frame update
    void Start()
    {
        anim();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            playershield.SetActive(false);
        }
    }

    void anim()
    {
        playershield.SetActive(true);
    }
}
