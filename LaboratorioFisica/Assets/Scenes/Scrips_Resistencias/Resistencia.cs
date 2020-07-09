using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistencia : MonoBehaviour
{

    public float voltaje;

    public float prueba;

    public float intesidadC;

    public float intesidadCR;

    public float resistencia;

    public float ramdom;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter(Collider other){

        //if(other.name.Equals("Proto1",System.StringComparison.OrdinalIgnoreCase)){ //no importe las mayusculas ni las minusculas System.StringComparison.OrdinalIgnoreCase
        if(other.gameObject.CompareTag("protoboard1")){    

            this.voltaje  = other.GetComponent<LineaProtoboard3>().obtenerVoltaje2();
            this.prueba = 80;
            this.intesidadC = hallarIntesidad();
            this.intesidadCR = hallarIntesidadR();
            this.ramdom = ramdon();

        }
        
        //}

        /*if(other.name.Equals("Proto2",System.StringComparison.OrdinalIgnoreCase)){ //no importe las mayusculas ni las minusculas System.StringComparison.OrdinalIgnoreCase

            other.GetComponent<Cables>().modificarVoltaje(this.voltaje);

        }*/

    }

    /*public static float obtenerIntesidad(){

        return intesidadC;

    }*/

    public float ramdon(){
       
        float numerorandom = Random.Range(99, 102) ; 

        float porcentaje = numerorandom/100;

        return porcentaje;

    }
    

    public float hallarIntesidad(){

        float resistencia2 = this.resistencia * ramdon();

        return intesidadC = this.voltaje/resistencia2;

    }

    public float hallarIntesidadR(){

        return intesidadCR = this.voltaje/this.resistencia;

    }

    public float obtenerVoltaje3(){

        return this.voltaje;

    }

    public float obtenerIntesidad(){

        return this.intesidadC;

    }

    /*public float obtenerVoltaje(){

        return this.voltaje;

    }

    public void modificarVoltaje(float voltaje){

        this.voltaje = voltaje ;

    }*/
}
