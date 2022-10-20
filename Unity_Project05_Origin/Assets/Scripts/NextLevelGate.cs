using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelGate : MonoBehaviour
{
    private const string PlayerTag = "Player";

    private GameManager _gameManager;  
    private void Start()
    {
        FindGameManager();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(PlayerTag)) return;

        FindGameManager();
        _gameManager.LoadNextLevel();
    }

    private void FindGameManager()
    {
        if (_gameManager != null) return;
        _gameManager = FindObjectOfType<GameManager>();
    }
}
