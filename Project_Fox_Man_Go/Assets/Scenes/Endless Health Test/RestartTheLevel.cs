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
