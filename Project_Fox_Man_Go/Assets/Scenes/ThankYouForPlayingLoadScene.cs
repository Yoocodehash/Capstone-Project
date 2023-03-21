using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThankYouForPlayingLoadScene : MonoBehaviour
{

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
