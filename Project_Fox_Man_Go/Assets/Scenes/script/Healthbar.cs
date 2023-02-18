using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    Image healthBar;
    float maxHealth = 100f;
    public static float health;

    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
    }

}




/*
public class Healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/


/*

public class Healthbar : MonoBehaviour
{

Image healthBar;
float maxHealth = 100f;
public static float health;

void Start()
{
healthBar = GetComponent<Image>();
health = maxHealth;
}

void Update()
{
healthBar.fillAmount = health / maxHealth;
}

}


 */