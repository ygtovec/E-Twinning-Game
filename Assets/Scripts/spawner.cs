using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    #region Variables
    public List<Transform> spawnPoints;
    public player characterScript;
    public List<GameObject> obstacles;
    public GameObject enemyDrone;
    public float time;
    public float distance;
    #endregion

    private void Start()
    {
        StartCoroutine(SpawnObject());
        StartCoroutine(DroneSpawner(5));
    }

    public IEnumerator SpawnObject()
    {

        while (!characterScript.isDead)
        {
            yield return new WaitForSeconds(Random.Range(2,8));

            //Instantiate(obstacles[Random.Range(0, 3)], new Vector3(distance, -3.9f, 0), Quaternion.identity);
            Instantiate(obstacles[2], new Vector3(distance, -3.9f, 0), Quaternion.identity);
        }
       
    }


    public IEnumerator DroneSpawner(float time)
    {
        while (!characterScript.isDead)
        {
        yield return new WaitForSeconds(15);

        Transform spawnPoint = spawnPoints[Random.Range(0, 2)];
        
        Instantiate(enemyDrone, new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0), Quaternion.identity);
        
        }
    }
}
