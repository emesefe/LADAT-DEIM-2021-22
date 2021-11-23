using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float timeDestroy = 2f;
    void Start()
    {
        // Destruye el objeto tras 2 segundos
        Destroy(gameObject, timeDestroy);
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Good"))
        {
            Destroy(gameObject);
            
            // Dar puntos
            // Sistema de partículas
            // Musiquita de ¡bien hecho!
        }else if (gameObject.CompareTag("Bad"))
        {
            Destroy(gameObject);
            
            // Game Over
            // Restar puntos
            // Quitar vida
            // Musiquita de Game Over o mal hecho
            // Sistema de partículas
            
        }
        
    }
}
