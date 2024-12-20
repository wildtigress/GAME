using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;
    public float spawnRate = 1f;
    public float spawnRangeX = 8f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnRate);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector2 spawnPosition = new Vector2(randomX, 6f);
        Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
    }
}
