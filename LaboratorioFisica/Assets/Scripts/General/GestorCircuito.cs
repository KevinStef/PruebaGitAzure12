using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorCircuito : MonoBehaviour
{
    public static GestorCircuito instance = null;
    public float componentesCircuitosConectado{get; set;}

    public bool circuitoConstruidoAlimentacion{get; set;}

    public bool voltajeListo {get; set;}

    public bool positivoOcupado{get;set;}

    public float conexionesDirectasCapacitor{get; set;}

    public bool conectadoAlimentador {get;set;}

    public bool deteccionCapacitor{get; set;}
    // Start is called before the first frame update
    void Start()
    {

        if(instance==null){
            instance=this;
        }else if(instance!=this){
            Destroy(gameObject);
        }
        componentesCircuitosConectado=0;

        voltajeListo = false;
    }

    public void ConexionCapacitor(){
        conexionesDirectasCapacitor++;
        Debug.Log("Conexiones : "+conexionesDirectasCapacitor);
        /*
        if(conexionesDirectasCapacitor>0){
            conectadoAlimentador=true;
        }
        */
        

        if(conexionesDirectasCapacitor>6){
             circuitoConstruidoAlimentacion=true;
             Debug.Log("Cantidad "+ conexionesDirectasCapacitor);
        }
    }

    public void DesconexionCapacitor(){
        conexionesDirectasCapacitor--;

        if(conexionesDirectasCapacitor<=6){
            //Debug.Log("Cantidad "+ conexionesDirectasCapacitor);
            circuitoConstruidoAlimentacion=true;
            voltajeListo = false;
        }
        if(conexionesDirectasCapacitor<1){
            conectadoAlimentador=false;
        }
    }

    public void ConstruccionCircuito(){
        componentesCircuitosConectado++;
        Debug.Log(componentesCircuitosConectado);
        if(componentesCircuitosConectado>=11)
        {
            circuitoConstruidoAlimentacion=true;
        }
    }

    public void DesconexionCircuito(){
        Debug.Log(componentesCircuitosConectado);
        componentesCircuitosConectado--;
        if(componentesCircuitosConectado<11){
            circuitoConstruidoAlimentacion=false;
            voltajeListo = false;
        }
    }

    
}
