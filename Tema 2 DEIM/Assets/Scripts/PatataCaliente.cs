using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PatataCaliente : MonoBehaviour
{
    private int counter;
    
    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(5, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        counter -= 1;
        if (counter <= 0)
        {
            Destroy(gameObject);
        }

        transform.localScale += 2 * Vector3.one;
        // transform.localScale += new Vector3(2, 2, 2);
    }
}
