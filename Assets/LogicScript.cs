using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject bird;

    public int playerScore = 0;
    public bool birdIsAlive = true;

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        bird.transform.rotation = Quaternion.Euler(bird.transform.rotation.x, bird.transform.rotation.y, -90);
        gameOverScreen.SetActive(true);
        birdIsAlive = false;
    }
}
