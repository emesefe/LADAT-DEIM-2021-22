using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject pivot;
    public float speed = 30;

    void Update()
    {
        transform.RotateAround(pivot.transform.position, Vector3.forward, speed * Time.deltaTime);
    }
}
