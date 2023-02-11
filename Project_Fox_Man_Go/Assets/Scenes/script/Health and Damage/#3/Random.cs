/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{

    public static int currentHealth = 100;
    public Slider healthBar;

    public static bool gameOver;

    void Start()
    {
        gameOver = false;
    }


    void Update()
    {

        currentHealth -= 1;


        healthBar.value = currentHealth;

        if (currentHealth < 0)
        {
            gameOver = true;
        }

    }


}

*/