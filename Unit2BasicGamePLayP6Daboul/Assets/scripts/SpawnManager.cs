using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Prefab Array")]
    public GameObject[] ballPrefabs; // Ensure you drag all 3 ball prefabs here

    [Header("Spawn Boundaries")]
    private float spawnLimitXLeft = -22.0f;
    private float spawnLimitXRight = 7.0f;
    private float spawnPosY = 30.0f;

    [Header("Timing Settings")]
    private float startDelay = 1.0f;

    void Start()
    {
        // Start the first spawn after a brief delay
        Invoke("SpawnRandomBall", startDelay);
    }

    void SpawnRandomBall()
    {
        // 1. Calculate a random X position within the boundaries
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // 2. Select a random ball index from the array
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // 3. Instantiate the selected ball at the random position
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // 4. Determine the next random spawn interval (Bonus Task)
        float nextSpawnInterval = Random.Range(3.0f, 5.0f);

        // 5. Recursively call this function to keep the cycle going
        Invoke("SpawnRandomBall", nextSpawnInterval);
    }
}

