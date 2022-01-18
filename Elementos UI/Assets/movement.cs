using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 targetPos;
    private float speed;
    private float totalSeconds = 2;
    private float totalDistance = 4; // 4m a recorrer

    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position + totalDistance * Vector3.forward;
        speed = Vector3.Distance(transform.position, targetPos) / totalSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 
            speed * Time.deltaTime);

        // Check if the position of the cube and sphere are approximately equal.
        /*if (Vector3.Distance(transform.position, targetPos) > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        }*/
    }
}
