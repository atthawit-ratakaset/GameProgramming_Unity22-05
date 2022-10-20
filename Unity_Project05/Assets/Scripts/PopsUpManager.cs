using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopsUpManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
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

    private void FindGameManager()
    {
        if (_gameManager != null) return;
        _gameManager = FindObjectOfType<GameManager>();
    }
}
