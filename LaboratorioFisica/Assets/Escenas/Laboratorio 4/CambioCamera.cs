using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamera : MonoBehaviour
{
    public Camera[] cams;
    public bool cam;
    void Start()
    {
        cam=false;
    }

    public void Update()
    {

    }
    public void CambioCam()
    {
            cams[0].enabled = true;
            cams[1].enabled = false;
     

    }
}
