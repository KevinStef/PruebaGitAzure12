using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPerillaMultimetroL4P1 : MonoBehaviour
{
    public GameObject perillaMultimetro;
    private Animator animacionPerilla;
    private string[] opciones;
    private int indice;

    private bool opcionSieteSeleccionado;
    void Start()
    {
        this.animacionPerilla = perillaMultimetro.GetComponent<Animator>();
        this.opciones = new string[] { "opcionUno", "opcionDos", "opcionTres", "opcionCuatro", "opcionCinco", "opcionSeis",
                                    "opcionSiete", "opcionOcho"};
        this.indice = 0;
        this.opcionSieteSeleccionado = false;
    }

    
    void Update()
    {

        tecladoControladorIndice();

        if (opciones[indice].Equals("opcionSiete", System.StringComparison.OrdinalIgnoreCase) && !opcionSieteSeleccionado)
        {
            CircuitoTerminadoL4P1.numeroConexiones++;
            this.opcionSieteSeleccionado = true;
        }else if (!opciones[indice].Equals("opcionSiete", System.StringComparison.OrdinalIgnoreCase) && opcionSieteSeleccionado)
        {
            CircuitoTerminadoL4P1.numeroConexiones--;
            this.opcionSieteSeleccionado = false;
        }

    }

    private void tecladoControladorIndice()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (indice>0)
            {
                animacionPerilla.SetBool(opciones[indice], false);
                this.indice--;
                animacionPerilla.SetBool(opciones[indice], true);
                
            }

            
        }

        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (indice < 7)
            {
                animacionPerilla.SetBool(opciones[indice], false);
                this.indice++;
                animacionPerilla.SetBool(opciones[indice], true);
            }
        }
    }
}
