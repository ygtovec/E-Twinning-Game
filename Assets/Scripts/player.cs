using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public spawner cuSpawner; 
        
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public int jump = 2;
    public scoreManager sayi;

    void Update()
    {
        if (jump >= 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2D.velocity = Vector2.up * velocity;
                jump -= 1;
            }
           
        }
       
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Ground")
        {
            jump = 2;
        }
        if (collider.gameObject.tag == "Obstacle")
        {
            isDead = true;
           
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "ScoreArea" && !isDead)
        {
            sayi.UpdateScore();
            
        }
    }

 }

