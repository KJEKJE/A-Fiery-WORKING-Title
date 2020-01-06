using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        string FinalScore = PlayerPrefs.GetInt("FinalScore").ToString();
        finalScore.text = "Final Score: " + FinalScore;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
