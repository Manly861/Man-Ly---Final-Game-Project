using UnityEngine;
public class SpawnRockManager : MonoBehaviour
{
    public GameObject [] rockPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRocks", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void SpawnRocks() 
    {
        // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int rockIndex = Random.Range(0, rockPrefabs.Length);
        Instantiate(rockPrefabs[rockIndex], spawnPos, rockPrefabs[rockIndex].transform.rotation);
    }
}