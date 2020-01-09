using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManaging : MonoBehaviour
{
    public void StartLvl1()
    {
        SceneManager.LoadScene("AFWT Level 1");
    }

    public void StartLvl2()
    {
        SceneManager.LoadScene("AFWT Level 2");
    }

    public void StartLvl3()
    {
        SceneManager.LoadScene("AFWT Level 3");
    }

    public void StartBoss()
    {
        SceneManager.LoadScene("AFWT Level EXTRA");
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
        SceneManager.LoadScene("You Win!");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}