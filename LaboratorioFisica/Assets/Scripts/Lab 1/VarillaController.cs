using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarillaController : MonoBehaviour {
    public int charge;
	// Use this for initialization
	void Start () {
        charge = 0;
	}
	
	// Update is called once per frame
	void Update () {

        //cuando haga click en k
        if(Input.GetKeyDown(KeyCode.K))
        {
            transform.GetComponent<Rigidbody>().MovePosition(new Vector3(0f, 10f, 20f));
        }
        //var x = Input.GetAxis("mouse x");
        //var y = Input.GetAxis("mouse y");
        //transform.Translate(x, y, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {//activa y deescativa colidder si hubo colision con "bola"
        Transform t = other.transform;
        if (t.tag == "Bola")
        {
            if(charge == 1)
            {
                
                this.GetComponent<SphereCollider>().isTrigger = false;
            }else if (charge == -1){
                //emporarily disable a collider on an object that is being hit with a raycast
                this.GetComponent<SphereCollider>().isTrigger = true;
            }
        }
    }
}
