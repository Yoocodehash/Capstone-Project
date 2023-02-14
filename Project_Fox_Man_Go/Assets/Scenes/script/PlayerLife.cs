using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    [SerializeField] AudioSource deathSound;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {

            //Debug.Log("You have died");
            Die();
        }

    }

    void Die()
    {
        //GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<Rigidbody>().isKinematic = true;
        //GetComponent<PlayerMovement>().enabled = false;
        //ReloadLevel();
        Invoke(nameof(ReloadLevel), 1.3f);

        deathSound.Play();

    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    

}
