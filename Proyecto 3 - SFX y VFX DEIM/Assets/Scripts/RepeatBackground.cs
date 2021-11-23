using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    
    void Start()
    {
        // Guardamos la posición inicial del fondo
        startPos = transform.position;
        // Tomamos la mitad de la anchura del fondo
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }
    
    void Update()
    {
        // Si nos desplazamos repeatWidth metros...
        if (transform.position.x < startPos.x - repeatWidth)
        {
            // Volvemos a la posición inicial
            transform.position = startPos;
        }
    }
}
