using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateGameObject(KeyCode.RightArrow, new Vector3(0, 10, 0));
        RotateGameObject(KeyCode.UpArrow, 10 * Vector3.right);
        
    }

    public void RotateGameObject(KeyCode kCode, Vector3 rotation)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.rotation *= Quaternion.Euler(rotation);
        }
    }
        
        
        
        
        
        
        
}
