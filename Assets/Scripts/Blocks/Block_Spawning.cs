using UnityEngine;
using System.Collections;

public class Block_Spawning : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;

    float timeToSpawn = 2f;
    float timeBetweenSpawn = 1f;

    public void Update()
    {
        if (Time.timeSinceLevelLoad >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.timeSinceLevelLoad + timeBetweenSpawn;
        }
    }

    public void SpawnBlocks()
    {
        int randomNumber = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i != randomNumber)
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
        }
    }
}