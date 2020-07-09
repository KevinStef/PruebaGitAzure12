using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitoTerminadoL4P1 : MonoBehaviour
{
    public static int numeroConexiones;

    public TextMesh voltajeTotal;
    public TextMesh intensidadCorriente;
    private float voltaje;
    public float resistencia;
    private float intensidad;

    void Start()
    {
        numeroConexiones = 0;

        this.intensidad = 0;
        this.voltaje = 0;

        valorResistencia();

        this.intensidadCorriente.text = intensidad.ToString("0.00");

    }

    
    void Update()
    {
        this.voltaje = float.Parse(voltajeTotal.text);

        if (numeroConexiones == 8)
        {
            ejecutarFormula();
        }else
        {
            this.intensidad = 0;
            this.intensidadCorriente.text = intensidad.ToString("0.00");
        }

    }

    private void ejecutarFormula()
    {
        this.intensidad = (voltaje / resistencia) * 1000;

        this.intensidadCorriente.text = intensidad.ToString("0.00");
    }

    private void valorResistencia()
    {
        int aleatorio = UnityEngine.Random.Range(1,5);

        switch (aleatorio)
        {
            case 1:
                this.resistencia = 98F;
                break;
            case 2:
                this.resistencia = 99F;
                break;
            case 3:
                this.resistencia = 101F;
                break;
            case 4:
                this.resistencia = 102F;
                break;
        }
    }

}
