using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SetScore : MonoBehaviour
{
    public Text finalScore;
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        string FinalScore = null;
        string HighScore = null;
        
        FinalScore = PlayerPrefs.GetInt("FinalScore").ToString();
        HighScore = PlayerPrefs.GetInt("HighScore").ToString();

        int thatScore = Convert.ToInt32(FinalScore);

        if (Convert.ToInt32(FinalScore) > Convert.ToInt32(HighScore))
        {
            PlayerPrefs.SetInt("HighScore", thatScore);
            Debug.Log(PlayerPrefs.GetInt("HighScore"));
            HighScore = PlayerPrefs.GetInt("HighScore").ToString();//set to new value
        }
        else
        {
            Debug.Log(PlayerPrefs.GetInt("HighScore"));
        }

        finalScore.text = "Final Score: " + FinalScore;
        highScore.text = "High Score: " + HighScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
