using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void OpenHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
