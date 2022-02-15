using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ManualPostProcess : MonoBehaviour
{
    public float vida = 100;
    private Volume volume;

    void Start()
    {
        volume = GetComponent<Volume>();
    }

    void Update()
    {
        if (vida < 20)
        {
            if (volume.profile.TryGet<Vignette>(out var vignette))
            {
                vignette.active = true;
                vignette.color.value = Color.red;
            }
        }
        else
        {
            if (volume.profile.TryGet<Vignette>(out var vignette))
            {
                vignette.active = false;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (volume.profile.TryGet<LensDistortion>(out var ld))
            {
                ld.active = true;
            }
        }
    }
}
