using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewRestart : MonoBehaviour
{
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


}
