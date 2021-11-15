using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float jumpForce = 500;
    public float gravityModifier = 1;
    public bool isOnTheGround = true;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, 
                ForceMode.Impulse);
            isOnTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Ground"))
        {
            isOnTheGround = true;
        } else if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
        
    }
}
