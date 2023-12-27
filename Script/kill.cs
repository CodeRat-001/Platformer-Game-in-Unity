using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class GameManager : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public UnityEngine.UI.Text scoreText;

    private bool gameIsOver = false;
    private int score = 0;

    void Start()
    {
        // Ensure the Game Over canvas is initially hidden
        if (gameOverCanvas != null)
        {
            gameOverCanvas.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Your game logic goes here

        // Update the score (replace this with your actual scoring logic)
        UpdateScore();
    }

    void UpdateScore()
    {
        // Replace this with your actual scoring logic
        score += 1;
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void OnDestroy()
    {
        // This method is called when the GameObject is destroyed (e.g., when the player is destroyed)
        if (!gameIsOver)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameIsOver = true;

        // Display the Game Over canvas
        if (gameOverCanvas != null)
        {
            gameOverCanvas.gameObject.SetActive(true);
        }
    }

    // You can call this method from a UI button to restart the game
    public void RestartGame()
    {
        // Reset game variables
        score = 0;
        gameIsOver = false;

        // Hide the Game Over canvas
        if (gameOverCanvas != null)
        {
            gameOverCanvas.gameObject.SetActive(false);
        }
    }
}
