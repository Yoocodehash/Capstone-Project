using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public GameObject panel;

    private void OnCollisionEnter(Collision collision)
    {
        panel.SetActive(true);
    }

}
