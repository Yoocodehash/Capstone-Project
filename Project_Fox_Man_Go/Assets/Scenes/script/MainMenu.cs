using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This will load a scene
    public void Play()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    //This will quit the game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("You have quit the game!");
    }

}
