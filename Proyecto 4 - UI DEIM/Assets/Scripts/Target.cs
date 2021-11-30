using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float timeDestroy = 2f;
    private GameManager gameManagerScript;

    [SerializeField] private int points;
    public ParticleSystem explosionParticle;
    
    void Start()
    {
        // Destruye el objeto tras 2 segundos
        Destroy(gameObject, timeDestroy);

        gameManagerScript = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        if (!gameManagerScript.gameOver)
        {
            // Dar o quitar puntos
            gameManagerScript.UpdateScore(points);
            
            Instantiate(explosionParticle, 
                transform.position, 
                explosionParticle.transform.rotation);
        }
        
        if (gameObject.CompareTag("Good"))
        {
            Destroy(gameObject);

            // Musiquita de ¡bien hecho!
            
        }else if (gameObject.CompareTag("Bad"))
        {
            Destroy(gameObject);
            gameManagerScript.missCounter += 1;

            if (gameManagerScript.missCounter >= gameManagerScript.totalMisses)
            {
                gameManagerScript.GameOver();
            }

            // Game Over
            // Restar puntos
            // Quitar vida
            // Musiquita de Game Over o mal hecho
            // Sistema de partículas

        }
        
        

        
        
    }

    private void OnDestroy()
    {
        gameManagerScript.targetPositions.Remove(transform.position);
    }
}
