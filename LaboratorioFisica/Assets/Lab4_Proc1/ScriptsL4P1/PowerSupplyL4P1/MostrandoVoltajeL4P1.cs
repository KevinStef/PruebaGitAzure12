using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MostrandoVoltajeL4P1 : MonoBehaviour
{
    public GameObject boton;
    public TextMesh voltajeTotal;

    private bool presionado;
    private static float voltaje;
    void Start()
    {
        voltaje = 0F;
        this.presionado = boton.GetComponent<PresionDeBotonL4P1>().estaPresionado();
    }

    void Update()
    {
        this.presionado = boton.GetComponent<PresionDeBotonL4P1>().estaPresionado();

        if (!presionado)
        {
            this.voltajeTotal.text = voltaje.ToString("0.00");
        }
        else if(presionado)
        {
            voltaje = 0F;
            this.voltajeTotal.text = voltaje.ToString("0.00");
        }
        
    }

    public static float obtenerTotalVoltaje()
    {
        return voltaje;
    }

    public static void modificarTotalVoltaje(float nuevoVoltajeTotal)
    {
        voltaje = nuevoVoltajeTotal;
    }

}
