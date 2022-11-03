using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PopsUpManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject pauseScreen;
    private GameManager _gameManager;
    private void Awake() 
    {
        isGameOver = false;
    }
    void Start()
    {   
        FindGameManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void RePlayAgain()
    {
        FindGameManager();
        _gameManager.ProcessPlayerDeath();
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        pauseScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
    }

    private void FindGameManager()
    {
        if (_gameManager != null) return;
        _gameManager = FindObjectOfType<GameManager>();
    }
}
