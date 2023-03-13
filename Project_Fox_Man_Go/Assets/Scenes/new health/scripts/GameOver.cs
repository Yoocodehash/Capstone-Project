using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("New Helath");
        }
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */



}



/*












using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
private void OnCollisionEnter(Collision collision)
{
if (collision.gameObject.CompareTag("Enemy"))
        {
DeathPlayer();
        }
}

}


void DeathPlayer()
    {
        Invoke(nameof(ReloadLevel), 1.3f);
        deathSound.Play();
    }

void ReloadLevel()
{ SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}




 */




/*

    public GameObject panel;

    private void OnCollisionEnter(Collision collision)
    {
        panel.SetActive(true);
    }


 */