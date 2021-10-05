using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class MyFirstScript : MonoBehaviour
{
     /*
    // playerAge guarda edad del jugador
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    [SerializeField]  private bool gameOver;
    */
     
     public string playerName = "Maria";
     public string enemyName = "Maria ";

     [SerializeField] private int x = 5;
     [SerializeField] private int y = 3;
     [SerializeField] private int z = 3;

     [SerializeField] private bool isRaining; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        /*
       Debug.Log(playerAge); 
       Debug.Log($"Hola {playerName}!");
       */
        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        */
        if (playerName == enemyName)
        {
            Debug.Log("Player y enemigo se llaman igual");
        }
        
        if (playerName != enemyName)
        {
            Debug.Log("Player y enemigo tienen distinto nombre");
        }
        
    }

    // Update is called once per frame
    
    void Update()
    {
        /*
        if (isRaining)
        {
            Debug.Log("Lleva un paraguas");
        }
        */
    }
    
}
