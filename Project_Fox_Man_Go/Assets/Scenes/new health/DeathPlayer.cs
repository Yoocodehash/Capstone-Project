using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlayer : MonoBehaviour
{

    //public GameObject GameOverCanvas;

    //GameOverCanvas.SetActive(true);


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
        }

    }




    /*
    public GameOverPlayer gameOverPlayer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //gameoverScreen.SetActive(true);
            gameOverPlayer.GameOverMenu;
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameoverScreen.SetActive(false);
    }



    public void GameOverMenu()
    {
        gameoverScreen.SetActive(true);
    }

    */





    /*
    private void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.CompareTag("Player"))
        {
  SceneManager.LoadScene("GameOverScreen");
        }
     }
     */




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
    public float RestartSpeed = 2f;
    bool GameIsOver = false;

    public void GameOver()
    {

        if (GameIsOver == false)
        {
            GameIsOver = true;
            Debug.Log("GameOver");
            Invoke("Restart", RestartSpeed);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
 */




/*
     public static bool isGameOver;
    public GameObject gameoverScreen;

    void Start()
    {
        isGameOver = false;
        gameoverScreen.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {

        if (isGameOver)
        {
            gameoverScreen.SetActive(true);
        }

    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
 */



/*
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("New Helath");
        }
    }
 */




/*
    [SerializeField] private GameObject restartUI;
    [SerializeField] private string ReloadLevel;

    // Start is called before the first frame update
    void Start()
    {
        LevelRestart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LevelRestart()
    {
        restartUI.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(ReloadLevel);
    }
*/






/*

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
    

*/