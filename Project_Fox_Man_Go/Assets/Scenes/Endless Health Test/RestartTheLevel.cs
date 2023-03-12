using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTheLevel : MonoBehaviour
{

    public void RestartLevel()
    {
        SceneManager.LoadScene("Endless Health Test");
    }

}



/*
 

using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
private void OnCollisionEnter(Collision collision)
{
if (collision.gameObject.CompareTag("Enemy"))
        {
SceneManager.LoadScene("Endless Health Test");
        }
}

}












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