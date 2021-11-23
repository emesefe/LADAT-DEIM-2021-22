using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;
    
    private Vector3 spawnPos = new Vector3(35, 0, 0);
    
    private PlayerController playerControllerScript;
    
    public GameObject[] obstaclePrefabs;
    
    void Start()
    {
        // Repetimos la función SpawnObstacle cada 2 segundos
        InvokeRepeating("SpawnObstacle", startDelay,
            repeatRate);
        
        // Accedemos a PlayerController para comunicarnos con ese script
        playerControllerScript = GameObject.Find("Player").
            GetComponent<PlayerController>();
    }

    private void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            // Generamos índice aleatorio para el array
            int randomIndex = Random.Range(0, 
                obstaclePrefabs.Length);
            
            // Hacemos aparecer obstáculo en escena
            Instantiate(obstaclePrefabs[randomIndex],
                spawnPos,
                obstaclePrefabs[randomIndex].transform.rotation);
        }
    }
}
