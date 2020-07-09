using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarConexionDigital : MonoBehaviour
{

    private void Start() {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(gameObject.CompareTag("fuentepoder")){
            /*
             if(other.gameObject.CompareTag("CablePositivo") || other.gameObject.CompareTag("CableDoblePunta"))
            {
                GestorCircuito.instance.positivoOcupado=true;
            }
            */
           
            if(other.gameObject.CompareTag("CablePositivo") ){
                
                GestorCircuito.instance.ConstruccionCircuito();
            }
            
        }else{
            GestorCircuito.instance.ConstruccionCircuito();
            if(other.gameObject.CompareTag("CableNegativo")){
                GestorCircuito.instance.ConexionCapacitor();
            }
           
        }

         

        
    }

    private void OnTriggerExit(Collider other) {
        if(gameObject.CompareTag("fuentepoder")){
            if(other.gameObject.CompareTag("CablePositivo") || other.gameObject.CompareTag("CableDoblePunta"))
            {
                GestorCircuito.instance.positivoOcupado=false;
            }
            if(other.gameObject.CompareTag("CablePositivo") ){
                GestorCircuito.instance.DesconexionCircuito();
            }
            
        }else{
            GestorCircuito.instance.DesconexionCircuito();
            if(other.gameObject.CompareTag("CableNegativo")){
                GestorCircuito.instance.DesconexionCapacitor();
            }
        }
    }
}
