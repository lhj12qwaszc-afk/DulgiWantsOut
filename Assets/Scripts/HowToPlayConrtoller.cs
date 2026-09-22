using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayController : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}