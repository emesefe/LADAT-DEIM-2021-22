using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherTrigger)
    {
        Destroy(otherTrigger.gameObject); // game object del animal
        Destroy(gameObject); // game object del proyectil
    }
}
