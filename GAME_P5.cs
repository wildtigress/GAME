using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;

    private int score = 0;
    private int lives = 3;

    void Update()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }

    public void AddScore()
    {
        score += 10;
    }

    public void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        // Show Game Over UI or restart the game
    }
}
