using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePivot : MonoBehaviour
{
    public GameObject sphere0;
    public GameObject sphere1;
    private bool isActive;

    void Start()
    {
        isActive = true;
        ChangeSphere(isActive);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isActive = !isActive;
            ChangeSphere(isActive);
        }
    }

    private void ChangeSphere(bool active)
    {
        sphere0.GetComponent<RotateAround>().enabled = active;
        sphere1.GetComponent<RotateAround>().enabled = !active;
    }
}
