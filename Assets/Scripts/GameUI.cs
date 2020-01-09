using UnityEngine;
using UnityEngine.UI;
using System;
public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;

    public int playerScore = 0;

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
    }
    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
    }
    private void UpdateHealthBar(int HP)
    {
        healthBar.value = HP;
    }
    private void UpdateScore(int theScore)
    {
        playerScore += theScore;

        scoreText.text = "Score: " + playerScore.ToString();
        PlayerPrefs.SetInt("FinalScore", playerScore);
        //Debug.Log(PlayerPrefs.GetInt("FinalScore"));
        //Debug.Log(PlayerPrefs.GetInt("HighScore"));


        //is the current high score broken?


    }

    //private void Awake()
    //{
    //    DontDestroyOnLoad(transform.gameObject);
    //
    //    int finalScore = 0 + playerScore;
    //    scoreText.text = "Final Score: " + playerScore.ToString();
    //}
}
