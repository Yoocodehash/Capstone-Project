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


}
