using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject dogPrefab;

    [Header("Spam Protection")]
    [Tooltip("Time in seconds between allowed dog spawns")]
    public float fireRate = 1.5f;
    private float nextFire = 0.0f;

    void Update()
    {
        // Only allow spawning if Space is pressed AND the cooldown time has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            // Update the 'nextFire' time to the current time plus the rate
            nextFire = Time.time + fireRate;
            SpawnDog();
        }
    }

    void SpawnDog()
    {
        // Spawns the dog at the player's current position and rotation
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}

