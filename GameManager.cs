using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

     void Awake()//makes timescale one, thus making the game run
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame();//start endgame method
        }
        else
        {
            gameOverText.gameObject.SetActive(false); //keep ui text game over hidden
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;//freeze time
    }
}
