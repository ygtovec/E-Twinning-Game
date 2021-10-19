using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public int score;
    public int bossCounter;
    public Text scoreText;
    
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    public void UpdateScore()
    {
        score++;
        bossCounter++;
        scoreText.text = score.ToString();
    }
    public void UpdateScore2()
    {
        score+= 2;
        bossCounter++;
        scoreText.text = score.ToString();
    }
    public void UpdateScore5()
    {
        score += 5;
        scoreText.text = score.ToString();
    }
}
