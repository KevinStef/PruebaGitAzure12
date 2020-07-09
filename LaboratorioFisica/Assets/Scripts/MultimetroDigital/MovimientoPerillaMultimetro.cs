using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPerillaMultimetro : MonoBehaviour
{
    public GameObject perillaMultimetro;
    private Animator animacionPerilla;
    private string[] opciones;
    private int indice;
    public static int indiceMultimetro;

    private static bool opcionCincoSeleccionado;
    private static bool opcionSieteSelecionado;

    void Start()
    {
        this.animacionPerilla = perillaMultimetro.GetComponent<Animator>();
        this.opciones = new string[] { "opcionUno", "opcionDos", "opcionTres", "opcionCuatro", "opcionCinco", "opcionSeis",
                                    "opcionSiete", "opcionOcho"};
        this.indice = 0;

        indiceMultimetro = this.indice;

        opcionCincoSeleccionado=false;
        opcionSieteSelecionado=false;
    }

    
    void Update()
    {

        tecladoControladorIndice();

        if (opciones[indice].Equals("opcionCinco", System.StringComparison.OrdinalIgnoreCase) && !opcionCincoSeleccionado)
        {
            opcionCincoSeleccionado = true;
        }else if (!opciones[indice].Equals("opcionCinco", System.StringComparison.OrdinalIgnoreCase) && opcionCincoSeleccionado)
        {  
            opcionCincoSeleccionado = false;
        }
        if (opciones[indice].Equals("opcionSiete", System.StringComparison.OrdinalIgnoreCase) && !opcionSieteSelecionado)
        {
            opcionSieteSelecionado = true;
        }else if (!opciones[indice].Equals("opcionSiete", System.StringComparison.OrdinalIgnoreCase) && opcionSieteSelecionado)
        {  
            opcionSieteSelecionado = false;
        }

    }

    private void tecladoControladorIndice()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (indice>0)
            {
                animacionPerilla.SetBool(opciones[indice], false);
                this.indice--;
                indiceMultimetro = this.indice;
                animacionPerilla.SetBool(opciones[indice], true);
                
            }

            
        }

        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (indice < 7)
            {
                animacionPerilla.SetBool(opciones[indice], false);
                this.indice++;
                indiceMultimetro = this.indice;
                animacionPerilla.SetBool(opciones[indice], true);
            }
        }
    }

     public static bool obteneropcion5(){
        return opcionCincoSeleccionado;
    }
    public static bool obteneropcion7(){
        return opcionSieteSelecionado;
    }

    
}
