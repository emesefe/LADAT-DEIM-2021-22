using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    
    private GameManager gameManagerScript;

    [SerializeField] private int points; // Puntos que da el target
    
    void Start()
    {
        // Destruye el objeto tras 2 segundos
        Destroy(gameObject, gameManagerScript.timeDestroy);

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

            Destroy(gameObject);

            if (gameObject.CompareTag("Good"))
            {
                // Musiquita de ¡bien hecho!
            }
            else if (gameObject.CompareTag("Bad"))
            {
                gameManagerScript.missCounter += 1;

                // Se da Game Over si le damos 3 veces a un objeto Bad
                if (gameManagerScript.missCounter >= gameManagerScript.totalMisses)
                {
                    gameManagerScript.GameOver();
                }

                // Musiquita de Game Over o mal hecho
            }
        }
    }

    private void OnDestroy()
    {
        gameManagerScript.targetPositions.Remove(transform.position);
    }
}
