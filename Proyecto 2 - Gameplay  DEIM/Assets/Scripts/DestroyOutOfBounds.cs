using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -5f;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Bala supera límite superior de pantalla
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }
        
        // Animal supera límite inferior de pantalla
        if (transform.position.z < lowerLim)
        {
            player = GameObject.Find("Player");
            Destroy(player);
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }
}
