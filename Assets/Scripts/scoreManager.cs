using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
