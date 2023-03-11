using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] private GameObject restartUI;
    [SerializeField] private string ReloadLevel;


    // Start is called before the first frame update
    void Start()
    {
        LevelRestart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    void LevelRestart()
    {
        restartUI.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(ReloadLevel);
    }


}
