using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public GameObject CurrentScore;
    TMP_Text CurrentScoreTX;

   

    // Start is called before the first frame update
    void Start()
    {
        CurrentScoreTX = CurrentScore.GetComponent<TMP_Text>();

        CurrentScoreTX.text = PlayerPrefs.GetString("CurrentScore");


    }


}
