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
        string FinalScore = PlayerPrefs.GetInt("FinalScore").ToString();
        //int HighScore = PlayerPrefs.GetInt("HighScore");

        //if (Convert.ToInt32(FinalScore) > HighScore)
        //{
        //    PlayerPrefs.SetInt("HighScore", Convert.ToInt32(FinalScore));
        //    
        //}

        finalScore.text = "Final Score: " + FinalScore;
        //highScore.text = "High Score: " + HighScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
