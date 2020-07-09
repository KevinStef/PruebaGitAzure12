using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConexionCables : MonoBehaviour
{

    public static bool conectado;

    public static bool conectado2;

    public static bool conectado3;

    public static bool conectado4;

    public string mensaje;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Rojo1")){

            conectado=true;
            mensaje = "conectado";

        }
        
        if(other.gameObject.CompareTag("Rojo2")){

            conectado2=true;
            mensaje = "conectado";

        }

        if(other.gameObject.CompareTag("Rojo3")){

            conectado3=true;
            mensaje = "conectado";

        }

        if(other.gameObject.CompareTag("Rojo4")){

            conectado4=true;
            mensaje = "conectado";

        }
        
    }

    void OnTriggerExit(Collider other)
    {
        
        if(other.gameObject.CompareTag("Rojo1")){

            conectado=false;
            mensaje = "No conectado";

        }
        
        if(other.gameObject.CompareTag("Rojo2")){

            conectado2=false;
            mensaje = "No conectado";

        }

        if(other.gameObject.CompareTag("Rojo3")){

            conectado3=false;
            mensaje = "No conectado";

        }

        if(other.gameObject.CompareTag("Rojo4")){

            conectado4=false;
            mensaje = "No conectado";

        }

    }


}
