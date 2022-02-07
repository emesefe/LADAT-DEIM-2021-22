using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMovement : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player.GetComponent<PlayerController>().enabled = false;
    }
    

    public void EnableMovement()
    {
        player.GetComponent<PlayerController>().enabled = true;
    }
}
