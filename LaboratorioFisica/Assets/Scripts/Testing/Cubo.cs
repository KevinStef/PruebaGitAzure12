using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour {
    public bool pressed;
    public float i = 0f;

    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButton(0))
        {
            float x = Input.GetAxis("Mouse X");
            i += x;
        }
        else
        {
            pressed = false;
        }
	}
}
