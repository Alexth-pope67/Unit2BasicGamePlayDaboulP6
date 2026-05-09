using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [Header("Thresholds")]
    private float lowerLimit = -5.0f; // For Balls
    private float leftLimit = -35.0f; // For Dogs

    void Update()
    {
        // LOGIC FOR BALLS (Checking Y axis)
        if (transform.position.y < lowerLimit)
        {
            Debug.Log("Game Over! A ball hit the ground.");
            Destroy(gameObject);
        }

        // LOGIC FOR DOGS (Checking X axis)
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }

    // Trigger logic for when a Dog and Ball overlap
    private void OnTriggerEnter(Collider other)
    {
        // If this object is a Ball and it hits a Dog...
        if (gameObject.CompareTag("Ball") && other.CompareTag("Dog"))
        {
            Destroy(gameObject); // Destroy the ball
            // Destroy(other.gameObject); // Optional: Uncomment to destroy dog too
        }
    }
}
