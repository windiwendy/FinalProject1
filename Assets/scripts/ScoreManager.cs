using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{

    public TMP_Text scoreText;
    public int currentSc;


   
    public void ChangesScore(int score)
    {
        currentSc += score;
        scoreText.text = currentSc.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
