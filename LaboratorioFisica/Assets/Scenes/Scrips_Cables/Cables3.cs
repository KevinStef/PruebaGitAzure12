using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cables3 : MonoBehaviour
{

    public float prueba;

    public float voltaje;

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

        if(other.gameObject.CompareTag("fuentePoder")){

            this.voltaje = other.GetComponent<EnviarVoltaje>().obtenerVoltaje();
            this.prueba = 80; 

        }else if (other.gameObject.CompareTag("protoboard2")){

            this.voltaje = other.GetComponent<LineaProtoboard4>().obtenerVoltaje4();
            this.intensidadC = other.GetComponent<LineaProtoboard4>().obtenerResistencia();

        }

    }
    
    public float obtenerVoltaje1(){

        return this.voltaje ;

    }

    public float obtenerVoltaje5(){

        return this.voltaje ;

    }

    public float obtenerResistencia(){

        return this.intensidadC;

    }

    


}
