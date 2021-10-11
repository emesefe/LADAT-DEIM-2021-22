using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class MyFirstScript : MonoBehaviour
{
     /*
    // playerAge guarda edad del jugador
    
    private float playerSpeed = 5.25f;
    [SerializeField]  private bool gameOver;
    
     
     
     
     public string playerName = "Maria";
     public string enemyName = "Maria ";

     [SerializeField] private int x = 5;
     [SerializeField] private int y = 3;
     [SerializeField] private int z = 3;
     */
     
     public int playerAge = 15;

     [SerializeField] private bool isRaining;
     [SerializeField] private bool isCold;
     
     // [SerializeField] private int playerHP = 10;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (playerAge % 4 == 0)
        {
            
        }
        
        /*
       Debug.Log(playerAge); 
       Debug.Log($"Hola {playerName}!");
       */
        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        
        if (playerName == enemyName)
        {
            Debug.Log("Player y enemigo se llaman igual");
        }
        
        if (playerName != enemyName)
        {
            Debug.Log("Player y enemigo tienen distinto nombre");
        }
        
        
        if (playerHP > 0)
        {
            Debug.Log("Sigues vivo");
        }
        else
        {
            Debug.Log("Estas muerto.");
        }
        

        if (playerAge < 13)
        {
            Debug.Log("Eres un niño");
        }
        else if (playerAge < 18)
        {
            Debug.Log("Eres adolescente");
        }
        else
        {
            Debug.Log("Eres adulto");
        }
        */
        
        
    }

    // Update is called once per frame
    
    void Update()
    {
        
        if (isRaining == true)
        {
            if (isCold)
            {
                Debug.Log("Lleva un paraguas y lleva una sudadera");
            }
            else
            {
                Debug.Log("Lleva un paraguas");
            }
        }
        else
        {
            Debug.Log("No llueve");
        }
        
    }
    
}
