using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    void LateUpdate()
    {
        // Cámara sigue al jugador a una distancia 
        transform.position = player.transform.position + offset;
    }
}
