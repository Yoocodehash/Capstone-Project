using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevelLoadButton : MonoBehaviour
{

    public void PlayTutorial()
    {
        SceneManager.LoadScene("Lab_level");
        //endPanel.setActive(false);

    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
        //endPanel.setActive(false);

    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("level-2");
        //endPanel.setActive(false);

    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level-3");
        //endPanel.setActive(false);

    }

    public void LoadThankYouScene()
    {
        SceneManager.LoadScene("ThanksForPlaying");
    }

    public void LoadEndlessRunnerLevel()
    {
        SceneManager.LoadScene("Final Stage");
    }

}
