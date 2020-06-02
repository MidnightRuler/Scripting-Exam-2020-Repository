using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public int winScore;
    public Button RetryButton;

    private void Start()
    {
        RetryButton.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (score > winScore)
        {
            RetryButton.gameObject.SetActive(true);
        }
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
    
    public void RetryButtonClicked()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
