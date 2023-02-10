/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public int maxHealth;
    public Healthbar healthbar;

    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth -= damage;
        healthbar.UpdateHealth((float)currentHealth / (float)maxHealth);
    }

}

*/