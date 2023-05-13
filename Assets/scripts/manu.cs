using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class manu : MonoBehaviour
{
  
    public void PlayGame()
    {
        SceneManager.LoadScene("gameScene");

    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
