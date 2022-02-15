using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ManualPostProcess : MonoBehaviour
{
    private Volume volume;
    
    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<Volume>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (volume.profile.TryGet<Vignette>(out var vignette))
            {
                vignette.active = true;
                vignette.color.value = Color.red;
            }
        }
    }
}
