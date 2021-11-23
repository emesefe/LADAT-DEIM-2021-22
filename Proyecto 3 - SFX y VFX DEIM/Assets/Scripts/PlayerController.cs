using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    
    private Animator playerAnimator;
    
    private AudioSource playerAudioSource;
    private AudioSource cameraAudioSource;
    
    private float jumpForce = 380f;
    private float gravityModifier = 0.9f;
    
    private bool isOnTheGround = true;
    public bool gameOver;
    
    public ParticleSystem explosionParticleSystem;
    public ParticleSystem dirtParticleSystem;
    
    public AudioClip jumpClip;
    public AudioClip explosionClip;
    
    void Start()
    {
        // Accedemos a las componentes
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
        cameraAudioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        
        Physics.gravity *= gravityModifier;
    }
    
    void Update()
    {
        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround && !gameOver)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, 
                ForceMode.Impulse);
            
            // Ejecutamos la animación de salto
            playerAnimator.SetTrigger("Jump_trig");
            
            // Paramos sistema de partículas de tierra
            dirtParticleSystem.Stop();
            
            // SFX de salto
            playerAudioSource.PlayOneShot(jumpClip, 1);
            
            // Ya no estamos en el suelo
            isOnTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (!gameOver)
        {
            if (otherCollider.gameObject.CompareTag("Ground"))
            {
                // Volvemos a activar las partículas de tierra
                dirtParticleSystem.Play();
                // Hacemos que isOnTheGround valga true porque hemos vuelto al suelo
                isOnTheGround = true;
            }
            else if (otherCollider.gameObject.CompareTag("Obstacle"))
            {
                // Seleccionar una muerte aleatoria (1 o 2)
                int randomDeathType = Random.Range(1, 3);
                // Ejecutamos la animación muerte (aleatoria)
                playerAnimator.SetBool("Death_b", true);
                playerAnimator.SetInteger("DeathType_int",
                    randomDeathType);

                // Activar sistema de partículas de explosión
                explosionParticleSystem.Play();
                // Desactivamos sistema de partículas de tierra
                dirtParticleSystem.Stop();
                
                // Bajamos volumen de la música
                cameraAudioSource.volume = 0.01f;
                // SFX de explosión
                playerAudioSource.PlayOneShot(explosionClip, 1);
                
                // Comunicamos que hemos muerto
                gameOver = true;
            }
        }

    }
}
