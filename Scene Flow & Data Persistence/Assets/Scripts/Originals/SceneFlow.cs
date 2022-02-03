using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{
    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("Game");
        UIManager.sharedInstance.SaveUserName();
    }
    
    public void ChangeToMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
