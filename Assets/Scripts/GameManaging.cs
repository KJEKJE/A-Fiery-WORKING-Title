using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManaging : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }
}