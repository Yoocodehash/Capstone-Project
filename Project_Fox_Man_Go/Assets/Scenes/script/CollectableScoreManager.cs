using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectableScoreManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Collectables: " + score;
    }


    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Collectables: " + score;
    }

}
