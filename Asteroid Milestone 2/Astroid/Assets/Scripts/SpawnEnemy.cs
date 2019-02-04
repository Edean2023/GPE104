using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemeyPrefab;

    float spawnDistance = 50;

    float enemyRate = 10;
    float nextEnemy = 1;

    // Update is called once per frame
    void Update()
    {
        nextEnemy -= Time.deltaTime;
      if(nextEnemy <= 0)
        {
            nextEnemy = enemyRate;
            enemyRate *= 0.9f;

            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;

            offset = offset.normalized * spawnDistance;

            Instantiate(enemeyPrefab, transform.position + offset, Quaternion.identity);
        }  
    }
}
