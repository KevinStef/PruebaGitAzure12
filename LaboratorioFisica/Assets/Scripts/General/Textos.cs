using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textos : MonoBehaviour {
    public ModuleManager mdManager;
    public string textoMensaje;
    public string textoSeleccion;
    public string textoAyuda;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseDown()
    {
      
        if(textoMensaje!="")
            mdManager.cambiarMensaje(textoMensaje);
        if (textoSeleccion != "")
            mdManager.cambiarSeleccion(textoSeleccion);
        if (textoAyuda != "")
            mdManager.cambiarAyuda(textoAyuda);


    }


}
