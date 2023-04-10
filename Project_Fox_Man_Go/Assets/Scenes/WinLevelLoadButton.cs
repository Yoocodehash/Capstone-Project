using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevelLoadButton : MonoBehaviour
{

    public void PlayTutorial()
    {
        SceneManager.LoadScene("Lab_level");
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("level-2");
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level-3");
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
