using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

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


}
