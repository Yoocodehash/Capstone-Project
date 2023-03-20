using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinReplayButton : MonoBehaviour
{

    public void ReplayLevel()
    {
        //SceneManager.LoadScene("New Helath");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //endPanel.setActive(false);

    }


}
