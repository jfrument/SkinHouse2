using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightManager : MonoBehaviour
{
    public Light pLight;
    public Light dLight;
    public Light sLight;

    int lightMode = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            toggleLight();
    }

    void toggleLight()
    {
        lightMode++;
        lightMode = lightMode % 3;
        switch(lightMode)
        {
            case 0:
                pLight.intensity = 0;
                sLight.intensity = 0;
                dLight.intensity = 0;
                break;
            case 1:
                pLight.intensity = 0.5f;
                sLight.intensity = 0.5f;
                dLight.intensity = 0.5f;
                break;
            case 2:
                pLight.intensity = 1.4f;
                sLight.intensity = 1.4f;
                dLight.intensity = 1.4f;
                break;
        }

    }
}
