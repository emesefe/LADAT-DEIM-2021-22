using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager sharedInstance;

    public TMP_InputField inputField;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        string existingUserName = PlayerPrefs.GetString("USER_NAME");
        if (existingUserName != "")
        {
            inputField.placeholder.GetComponent<TextMeshProUGUI>().text = existingUserName;
        }
    }

    public void SaveUserName()
    {
        string inputText = inputField.text;
        if (inputText == "")
        {
            DataPersistence.sharedInstance.userName = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            DataPersistence.sharedInstance.userName = inputText;
        }
        
        PlayerPrefs.SetString("USER_NAME", DataPersistence.sharedInstance.userName);
    }
}
