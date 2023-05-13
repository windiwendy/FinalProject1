using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{

    public TMP_Text scoreText;
    public int currentSc;


    private void Start()
    {
        PlayerPrefs.SetString("CurrentScore", "0");

    }
    public void ChangesScore(int score)
    {
        currentSc += score;
        scoreText.text = currentSc.ToString();
        PlayerPrefs.SetString("CurrentScore", scoreText.text);
    }


}
