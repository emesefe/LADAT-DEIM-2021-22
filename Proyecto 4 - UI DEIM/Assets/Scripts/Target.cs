using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    
    private GameManager gameManagerScript;

    [SerializeField] private int points; // Puntos que da el target
    private bool clickedOnGoodTarget;
    
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();
        
        // Destruye el objeto tras 2 segundos
        Destroy(gameObject, gameManagerScript.timeDestroy);
    }

    private void OnMouseDown()
    {
        if (!gameManagerScript.gameOver)
        {
            // Dar o quitar puntos
            gameManagerScript.UpdateScore(points);

            // Instanciamos el sistema de partículas
            Instantiate(explosionParticle,
                transform.position,
                explosionParticle.transform.rotation);
            // Destruimos el objeto
            Destroy(gameObject);

            if (gameObject.CompareTag("Good"))
            {
                clickedOnGoodTarget = true;
                // TODO: Musiquita de ¡bien hecho!
            }
            else if (gameObject.CompareTag("Bad"))
            {
                IsGameOver();

                // TODO: Musiquita de Game Over o mal hecho
            }
        }
    }
    
    private void IsGameOver()
    {
        if (!gameManagerScript.gameOver)
        {
            gameManagerScript.missCounter += 1;
            gameManagerScript.UpdateLives();

            // Se da Game Over si le damos 3 veces a un objeto Bad
            if (gameManagerScript.missCounter >= gameManagerScript.totalMisses)
            {
                gameManagerScript.GameOver();
            }
        }
    }

    private void OnDestroy()
    {
        // Comunicamos a GameManager que la posición ha quedado libre
        gameManagerScript.targetPositions.Remove(transform.position);

        if (gameObject.CompareTag("Good") && !clickedOnGoodTarget)
        {
            IsGameOver();
        }
    }
}
