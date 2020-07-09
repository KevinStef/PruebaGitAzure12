using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuito : MonoBehaviour
{
    public string mensaje;
    public bool estad;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Proto")){
            mensaje = other.GetComponent<Protoboard>().obtenerMensaje(); 
            estad=true;
        }
    }
    private void OnTriggerExit(Collider other){
        this.mensaje="No conectado";
    }
    public string obtenerMensaje(){
        return this.mensaje;
    }
}
