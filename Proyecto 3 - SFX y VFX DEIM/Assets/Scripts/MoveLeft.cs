using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f;

    private PlayerController playerControllerScript;
    private float lowerLimit = -1;
    
    void Start()
    {
        // Nos comunicamos con el script PlayerController
        playerControllerScript = GameObject.Find("Player").
            GetComponent<PlayerController>();
    }

    void Update()
    {
        // Movemos a la izquierda
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * 
                                speed * Time.deltaTime);
        }
        
        // Eliminar Game Objects no necesarios
        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
