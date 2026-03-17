using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
        }

        // Check if the object we hit has the tag "Food"
        if (other.CompareTag("Food"))
        {
            // Update the score in your GameManager
            GameObject.Find("Game Manager").GetComponent<GameManager>().AddScore(1);

            Destroy(gameObject);      // Destroy the animal
            Destroy(other.gameObject); // Destroy the food projectile
        }

    }
}

