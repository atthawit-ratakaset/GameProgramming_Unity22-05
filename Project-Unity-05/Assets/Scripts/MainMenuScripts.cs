using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

    public void ReturnToTitle()
    {
        SceneManager.LoadScene(0);
    }
    
    private void FindGameManager()
    {
        if (_gameManager != null) return;
        _gameManager = FindObjectOfType<GameManager>();
    }
}
