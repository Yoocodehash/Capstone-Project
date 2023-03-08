using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        //Make sure that the scene is
        //added to build settings
        SceneManager.LoadScene(2);
    }
}
