using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 targetPos;
    private float speed;
    private float totalSeconds = 2; // Duración total del movimiento
    private float totalDistance = 4; // 4m a recorrer
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        // targetPos = transform.position + totalDistance * Vector3.forward;
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving && Input.GetAxisRaw("Horizontal") != 0)
        {
            targetPos = transform.position + totalDistance * Vector3.forward;
            StartCoroutine(Move(targetPos, totalSeconds));
        }
        
        if (!isMoving && Input.GetAxisRaw("Vertical") != 0)
        {
            targetPos = transform.position + totalDistance * Vector3.forward;
            StartCoroutine(Move(targetPos, totalSeconds));
        }

        // Check if the position of the cube and sphere are approximately equal.
        /*if (Vector3.Distance(transform.position, targetPos) > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        }*/
    }
    
    private IEnumerator Move(Vector3 targetPosition, float duration)
    {
        if (isMoving) yield break; // Si nos estamos moviendo, nada

        // Si estábamos quietos, iniciamos movimiento
        isMoving = true;
        
        // Configuramos la velocidad en función de la distancia a recorrer y el tiempo total del recorrido
        speed = Vector3.Distance(transform.position, targetPos) / totalSeconds;
        float passedTime = 0f;

        // Mientras el tiempo transcurrido no supere la duración total, nos movemos hacia targetPos
        while (passedTime < duration)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos,
                speed * Time.deltaTime);
            
            // Aumentamos el tiempo transcurrido
            passedTime += Time.deltaTime;
            
            // Pasamos al siguiente frame
            yield return null;

        }

        // Al acabar, nos aseguramos de que nuestra posición, sea la posición objetivo
        transform.position = targetPosition;
        // Ya no nos movemos
        isMoving = false;
    }
}


