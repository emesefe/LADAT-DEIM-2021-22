using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;
    public float jumpForce = 500;
    public float gravityModifier = 1;
    public bool isOnTheGround = true;
    public bool gameOver;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, 
                ForceMode.Impulse);
            playerAnimator.SetTrigger("Jump_trig");
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
            gameOver = true;
        }
        
    }
}
