using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviarVoltaje : MonoBehaviour
{
    public float voltaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter(Collider other){

        if(other.name.Equals("CableP1",System.StringComparison.OrdinalIgnoreCase)){ //no importe las mayusculas ni las minusculas System.StringComparison.OrdinalIgnoreCase

            other.GetComponent<Cables>().modificarVoltaje(this.voltaje); 

        }

    } */

    public float obtenerVoltaje(){

        return this.voltaje;

    }


}
