using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayHello : MonoBehaviour
{
    [SerializeField] private string playerName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerName = GetComponent<InputField>().text;
            Debug.Log($"¡Hola, {playerName}!");
        }
    }
}
