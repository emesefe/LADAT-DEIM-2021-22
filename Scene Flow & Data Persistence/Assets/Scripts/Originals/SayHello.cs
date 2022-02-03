using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SayHello : MonoBehaviour
{

    private TextMeshProUGUI helloText;

    private void Awake()
    {
        helloText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        helloText.text = $"Hola, {DataPersistence.sharedInstance.userName}";
    }
}
