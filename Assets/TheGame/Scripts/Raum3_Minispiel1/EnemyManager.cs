using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemy;
    public float spawnTime = 1.3f;
    public Transform[] spawnPoints;

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
        // Start is called before the first frame update
        void Start()
    {
        StartCoroutine(wait());
        
    }

    void Spawn ()
    {
        //picks random spawn point
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemy.Length);

        //spawn (what, where, with which rotation)
        Instantiate(enemy[enemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
    // Update is called once per frame
    void Update()
    {
          
    }
}
