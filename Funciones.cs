using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Funciones : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    private string message;

    void Start()
    {
        message = "Pulsa cualquier flecha";
        textTMP.text = message;
    }
    void Update()
    {
        MyShowMessage(KeyCode.rightArrow, "derecha");
        MyShowMessage(KeyCode.leftArrow, "izquierda");
        MyShowMessage(KeyCode.upArrow, "arriba");
        MyShowMessage(KeyCode.downArrow, "abajo");
        MyShowMessage(KeyCode.A, "AAAAAAAAA");
        MyShowMessage(KeyCode.P, "Pium Pium");
        MyShowMessage(KeyCode.M, "Muu");
        MyShowMessage(KeyCode.T, "Tomate");

    }
    
    public void MyShowMessage(KeyCode kCode, string msg)
    {
        if (Input.GetKeyDown(kCode))
        {
            textTMP.text = msg;
        }
    }

    public void ShowMessage(KeyCode kCode, string msg)
    {
        if (Input.GetKeyDown(KeyCode.rightArrow))
        {
            message = "derecha";
        }
        
        if (Input.GetKeyDown(KeyCode.leftArrow))
        {
            message = "izquierda";
        }
        
        if (Input.GetKeyDown(KeyCode.upArrow))
        {
            message = "arriba";
        }
        
        if (Input.GetKeyDown(KeyCode.downArrow))
        {
            message = "abajo";
        }
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            message = "Muu";
        }
    }
    
    
        
        
        
        
        
        
        
}
