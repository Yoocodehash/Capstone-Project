using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinQuitButton : MonoBehaviour
{

    public void Quit()
    {
        Application.Quit();
        Debug.Log("You have quit the game!");
    }

}
