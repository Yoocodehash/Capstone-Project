using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPlayer : MonoBehaviour
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

    public void Restart()
    {
        //SceneManager.LoadScene("New Helath");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("You have quit the game!");
    }

}

