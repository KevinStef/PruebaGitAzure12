using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour {

    Rigidbody rb;
    public Vector3 vel;

	// Use this for initialization
	void Start () {
        
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = vel;
		
	}
}
