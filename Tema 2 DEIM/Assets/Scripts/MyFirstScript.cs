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
    
     
     public string enemyName = "Maria ";
     [SerializeField] private int z = 3;
     
     
     public int playerAge = 15;

     [SerializeField] private bool isRaining;
     [SerializeField] private bool isCold;
     */
     
     // [SerializeField] private int playerHP = 10;
    
     public string playerName = "Jose";
     [SerializeField] private int x = 5;
     [SerializeField] private int y = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        x -= y;
        // transform.position = new Vector3(0, 0, 0);
        transform.position = Vector3.zero;
        
        HelloWorld();
        HelloName("Maria");
        HelloName(playerName);
        Debug.Log(GetHello());
        Debug.Log($"{x} + {y} = {Sum(x, y)}");

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
    
    private void Update()
    {    
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale += Vector3.right;
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale -= Vector3.right;
        }
        
        /*
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
            // transform.position -= Vector3.right;
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.down;
            // transform.position -= Vector3.up;
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
            // transform.position -= Vector3.forward;
        }
        */
        
        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);
        
        
        
        /*
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
        */
        
    }

    public void HelloWorld()
    {
        Debug.Log("¡Hola, mundo!");
    }
    
    public void HelloName(string name)
    {
        Debug.Log($"¡Hola, {name}!");
    }

    public string GetHello()
    {
        return "Hola";
    }

    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.position += direction;
        }
    }
    
}
