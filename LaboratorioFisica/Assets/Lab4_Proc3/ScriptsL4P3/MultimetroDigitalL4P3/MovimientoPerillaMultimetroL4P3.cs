using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPerillaMultimetroL4P3 : MonoBehaviour
{
    //variables publicas
    public GameObject perillaMultimetro;

    //variables privadas
    private Animator animacionPerilla;
    private string[] opciones;
    private int indice;
    private bool opcionCincoSeleccionado;
    void Start()
    {
        //se alamcena la animacion de la perillas
        this.animacionPerilla = perillaMultimetro.GetComponent<Animator>();

        //se gestiona un array que controle cada movimiento del selector
        this.opciones = new string[] { "opcionUno", "opcionDos", "opcionTres", "opcionCuatro", "opcionCinco", 
                                    "opcionSeis","opcionSiete", "opcionOcho"};
        this.indice = 0;
        this.opcionCincoSeleccionado = false;
    }
    void Update()
    {

        tecladoControladorIndice();

        /*
         Se controla que la perillas se encuentre en el simbolo de miliamperios
         */
        if (opciones[indice].Equals("opcionCinco", System.StringComparison.OrdinalIgnoreCase) && 
            !opcionCincoSeleccionado)
        {
            CircuitoTerminadoL4P3.numeroConexiones++;
            this.opcionCincoSeleccionado = true;
        }else if (!opciones[indice].Equals("opcionCinco", System.StringComparison.OrdinalIgnoreCase) && 
            opcionCincoSeleccionado)
        {
            CircuitoTerminadoL4P3.numeroConexiones--;
            this.opcionCincoSeleccionado = false;
        }

    }

    /*
     Se controla la animación de girar a la izquierda o derecha con las felchas arriba y abajo del teclado
     */
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
