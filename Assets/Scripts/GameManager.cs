using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public player robot;
    public GameObject DeathMenu;
    
    void Update()
    {
        if (robot.isDead)
        {
            Time.timeScale = 0;
            DeathMenu.SetActive(true);
            
        }
        
    }
    public void Retry()
    {
        SceneManager.LoadScene(0);
        
    }
}
