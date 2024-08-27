using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //text mesh pro name space added to access unity libraries for UI
public class ScoreManager : MonoBehaviour
{
    public int score; // keeps score value

    public TextMeshProUGUI scoreText;// visual text element to be modified

    public void IncreaseScore(int amount) // This method when called increases the score by a predetermied amount set in score variable
    {
        score += amount;
        UpdateScoreText(); 
        Debug.Log(score);
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
       
    }

    public void UpdateScoreText() //this method updates the score in the HUD UI test
    {
        scoreText.text = "Score: " + score;
    }
}
 
