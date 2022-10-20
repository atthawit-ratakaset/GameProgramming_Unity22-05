using UnityEngine;
using UnityEngine.InputSystem;

public class MainMenuScripts : MonoBehaviour
{   
    private GameManager _gameManager;

    private void Start()
    {   
        FindGameManager();
    }
    
    public void PlayButton()
    {
        _gameManager.LoadNextLevel();
    }
    
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
    
    private void FindGameManager()
    {
        if (_gameManager != null) return;
        _gameManager = FindObjectOfType<GameManager>();
    }
}
