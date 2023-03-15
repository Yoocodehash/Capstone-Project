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





/*
 public float speed = 0;
public TextMeshProGUI countText;
public GameObject winTextObject;
public Transform respawnPoint;
public MenuController menuController;

void Start()
{
SetCountText();
//winTextObject.SetActive(false);
}

private void Update()
{
if(transform.position.y < -10)
{
Respawn();
}

void SetCountText()
{
countText.text = "Count: " + count.ToString();
if(count >= 12)
{
//winTextObject.SetActive(true);
menuController.WinGame();
}

}

void OnTriggerEnter(Collider other)
{
if(other.gameObject.CompareTag("PickUp"))
{
other.gameObject.SetActive(false);
count = count + 1;
SetCountText();
}

}

void OnCollisionEnter(Collider Collision)
{
if(other.gameObject.CompareTag("Enemy"))
{
//Respawn();
EndGame();
}

}

void Respawn()
{
transform.position = respawnPoint.position;
}

void EndGame()
{
menuController.LoseGame();
gameObject.SetActive(false);
}



}

 */




