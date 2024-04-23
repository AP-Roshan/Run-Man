using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float spawnRange = 8f;

    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnObstacle()
    {
        float xPos = Random.Range(spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3( xPos, transform.position.x, xPos);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}