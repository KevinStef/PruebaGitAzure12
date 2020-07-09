using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {
    public float i;
	// Use this for initialization
	void Start () {
        i = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        //Si Pressed primary button
        //i cronometro teimpo de clicks
        if (Input.GetMouseButtonDown(0))
        {
            i += 1 * Time.deltaTime;
        }
	}
}
