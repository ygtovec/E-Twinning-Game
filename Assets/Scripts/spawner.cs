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
    public GameObject FMan;
    public scoreManager scoreM;
    public float time;
    public float distance;
    public bool noBoss = true;
    #endregion

    private void Start()
    {
        StartCoroutine(SpawnObject());
        StartCoroutine(DroneSpawner(5));
    }
    public void ResumeSpawn()
    {
        StartCoroutine(SpawnObject());
        StartCoroutine(DroneSpawner(5));
    }
    void Update()
    {
      if(scoreM.bossCounter >= 20)
        {
            noBoss = false;
            StartCoroutine(SpawnFMan());
            scoreM.bossCounter = 0;
        }
    }
    public IEnumerator SpawnObject()
    {

        while (!characterScript.isDead &&noBoss)
        {
            yield return new WaitForSeconds(Random.Range(2,8));

            //Instantiate(obstacles[Random.Range(0, 3)], new Vector3(distance, -3.9f, 0), Quaternion.identity);
            Instantiate(obstacles[2], new Vector3(distance, -3.9f, 0), Quaternion.identity);
        }
       
    }


    public IEnumerator DroneSpawner(float time)
    {
        while (!characterScript.isDead && noBoss)
        {
        yield return new WaitForSeconds(15);

        Transform spawnPoint = spawnPoints[Random.Range(0, 2)];
        
        Instantiate(enemyDrone, new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0), Quaternion.identity);
        
        }
    }

    public IEnumerator SpawnFMan()
    {
        yield return new WaitForSeconds(5);
        Instantiate(FMan, new Vector3(distance, -3.9f, 0), Quaternion.identity);
    }
}
