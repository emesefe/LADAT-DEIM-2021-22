using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    private Slider slider;

    private void Start()
    {
        /*
        slider.value = 0f;
        slider.minValue = 0f;
        slider.interactable = false;
        */
    }

    public void ResizeCube(float sizeMultiplier)
    {
        transform.localScale = sizeMultiplier * Vector3.one;
    }

    public void ChangePos(float xPos)
    {
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
