using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class MyFirstScript : MonoBehaviour
{
    // playerAge guarda edad del jugador
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Maria";
    [SerializeField]  private bool gameOver;

    
    
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(playerAge); 
       Debug.Log($"Hola {playerName}!");
    }

    // Update is called once per frame
    /*
    void Update()
    {
        
    }
    */
}
