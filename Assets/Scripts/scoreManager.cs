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
    public void UpdateScore(int temp)
    {
        score+= temp;
        bossCounter++;
        scoreText.text = score.ToString();
    }
}
