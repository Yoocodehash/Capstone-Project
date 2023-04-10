using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public void Tutorial()
    {
        SceneManager.LoadScene("Lab_level");
    }


    public void EscapeLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void NatureLevel()
    {
        SceneManager.LoadScene("level-2");
    }

    public void CityLevel()
    {
        SceneManager.LoadScene("Level-3");
    }

    public void EndlessRunnerLevel()
    {
        SceneManager.LoadScene("Final Stage");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("You have quit the game!");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
