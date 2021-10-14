using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public player characterScript;
    public GameObject obstacle1;
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
         
            Instantiate(obstacle1, new Vector3(distance, -3.9f, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
       
    }
}
