using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManaging : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("AFWT Level 1");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
        //AudioSource gameMusic;
        //gameMusic = GetComponent<AudioSource>();
        //gameMusic.Stop();
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("How To Play");
    }
    public void YouWin()
    {
        SceneManager.LoadScene("Congrats!");
    }
}