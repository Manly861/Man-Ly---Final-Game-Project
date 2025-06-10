using UnityEngine;
using System.Collections;
public class SpawnPowerupManager : MonoBehaviour
{
   public GameObject [] powerUpPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 5;
    private float minDelay = 5.0f;
    private float maxDelay = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnPowerUpRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnPowerUpRoutine() 
    {
        yield return new WaitForSeconds(5f);
        while(true)
        {
            SpawnPowerUp();
            float randomDelay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(randomDelay);
       }
    }
    public void SpawnPowerUp()
    {
        // Randomly generate powerup index and spawn position
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        float randomZ = Random.Range(-spawnPosZ, spawnPosZ);
        Vector3 spawnPos = new Vector3(randomX, 0, randomZ);

        int powerUpIndex = Random.Range(0, powerUpPrefabs.Length);
        Instantiate(powerUpPrefabs[powerUpIndex], spawnPos, powerUpPrefabs[powerUpIndex].transform.rotation);
        Debug.Log("Powerup has spawned!");
    }
}
