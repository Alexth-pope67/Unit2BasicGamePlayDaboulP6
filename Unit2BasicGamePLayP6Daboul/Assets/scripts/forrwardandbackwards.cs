using UnityEngine;

public class forrwardandbackwards : MonoBehaviour
{
    public float speed = 10.0f;
    public float zRange = 10.0f; // To keep the player within a certain range
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from Up/Down arrows or W/S keys
        verticalInput = Input.GetAxis("Vertical");

        // Move the player forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Optional: Keep the player within a specific range (e.g., -10 to 10)
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}


