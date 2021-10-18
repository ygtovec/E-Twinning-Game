using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    #region Variables
    public Transform spawnPoint;
    public player characterScript;
    public List<GameObject> obstacles;
    public GameObject enemyDrone;
    public float time;
    public float distance;
    #endregion

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
        StartCoroutine(DroneSpawner(5));
    }

    public IEnumerator SpawnObject(float time)
    {

        while (!characterScript.isDead)
        {
         
            Instantiate(obstacles[Random.Range(0,2)], new Vector3(distance, -3.9f, 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
       
    }


    public IEnumerator DroneSpawner(float time)
    {
        while (!characterScript.isDead)
        {
            Instantiate(enemyDrone, new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
