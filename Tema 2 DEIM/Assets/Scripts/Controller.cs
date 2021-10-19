using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Controller : MonoBehaviour
{
    private float limX = 12.0f;
    private float limYPos = 5.0f;
    private float limYNeg = -3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);
        
        // Límites de Pantalla
        if (transform.position.x >= limX)
        {
            transform.position = new Vector3(limX, transform.position.y, 
                transform.position.z);
        }
        
        if (transform.position.x <= -limX)
        {
            transform.position = new Vector3(-limX, transform.position.y, 
                transform.position.z);
        }
        
        if (transform.position.y >= limYPos)
        {
            transform.position = new Vector3(transform.position.x, limYPos, 
                transform.position.z);
        }
        
        if (transform.position.y <= limYNeg)
        {
            transform.position = new Vector3(transform.position.x, limYNeg, 
                transform.position.z);
        }
    }
    
    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.position += direction;
        }
    }
    
    
    
}
