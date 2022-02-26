using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void GoToGameScene()
    {
        UIManagerMenu.sharedInstance.SaveUserName();
        SceneManager.LoadScene("Game_Start");
    }

    public void GoToMenuScene()
    {
        SceneManager.LoadScene("Menu_Start");
    }

    public void ExitGame()
    {
        // Guardo lo que quiero
        Debug.Log("Bye bye");
        Application.Quit();
    }
    
}
