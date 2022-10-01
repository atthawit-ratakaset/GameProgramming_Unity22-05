using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MainMenuScripts : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Level 1");
    }
    
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
    
    private void OnQuit(InputValue value)
    {
        if (!value.isPressed) return;
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitButton();
            Debug.Log("Escape was pressed");
        }
        else
        {
            Debug.Log("Start");
            PlayButton();
        }
    }
}
