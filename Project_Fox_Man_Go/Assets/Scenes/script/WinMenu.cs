using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class WinMenu : MonoBehaviour
{

    public GameObject winPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    
    public void WinGame()
    {

        winPanel.SetActive(true);
        winPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You Win!";

    }






    /*
    public void ReplayLevel()
    {
        //SceneManager.LoadScene("New Helath");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        //endPanel.setActive(false)

    }


    public void PlayLevel2()
    {
        SceneManager.LoadScene("level-2");

        //endPanel.setActive(false)

    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level 3");

        //endPanel.setActive(false)

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

        //endPanel.setActive(false)

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("You have quit the game!");
    }


    */




}
