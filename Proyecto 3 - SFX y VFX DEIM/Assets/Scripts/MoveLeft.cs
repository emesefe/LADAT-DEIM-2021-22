using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
