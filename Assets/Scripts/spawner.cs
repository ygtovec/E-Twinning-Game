using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public player characterScript;
    public List<GameObject> obstacles;
    public float time;
    public float distance;
   
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {

        while (!characterScript.isDead)
        {
         
            Instantiate(obstacles[Random.Range(0,2)], new Vector3(distance, -3.9f, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
       
    }
}
