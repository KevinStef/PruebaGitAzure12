using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineaProtoboard3 : MonoBehaviour
{  

    public float prueba;

    public float voltaje;

    public float voltaje2;

    public float intensidadC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){

        /*if(other.gameObject.CompareTag("cable1")){

            this.voltaje = other.GetComponent<Cables3>().obtenerVoltaje1();
            this.prueba = 40;

        }else if(other.gameObject.CompareTag("resistencia")){

            this.voltaje = other.GetComponent<Resistencia>().obtenerVoltaje3();
            this.intensidadC = other.GetComponent<Resistencia>().obtenerIntesidad();  
            this.prueba = 80;
        }*/

        switch(other.gameObject.tag){

            case "cable1":

            this.voltaje = other.GetComponent<Cables3>().obtenerVoltaje1();
            this.prueba = 40;

            break;

        }
        

    } 

    public float obtenerVoltaje2(){

        return voltaje;

    }

    public float obtenerVoltaje4(){

        return this.voltaje;

    }

    public float obtenerResistencia(){

        return this.intensidadC;

    }




    /*public void obtenerVoltaje1(float voltaje){

        this.voltaje = voltaje ;

    }*/


 }