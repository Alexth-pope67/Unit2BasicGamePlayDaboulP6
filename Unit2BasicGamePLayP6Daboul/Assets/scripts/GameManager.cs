using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 1. Initialize variables
    public int lives = 3;
    public int score = 0;

    void Start()
    {
        // 2. Display starting stats in the console
        Debug.Log("Lives = " + lives);
        Debug.Log("Score = " + score);
    }

    // 3. Method to increase and display score when an animal is fed
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }

    // 4. Method to decrease and display lives
    public void SubtractLives(int value)
    {
        lives -= value;
        Debug.Log("Lives = " + lives);

        // 5. Check for Game Over
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0; // Prevents negative lives in the console
        }
    }
}


