using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMainMenuButton : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        //endPanel.setActive(false);

    }

}
