using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitoTerminadoL4P3 : MonoBehaviour
{

    public static List<GameObject> resistenciasTocadas;
    public static int numeroConexiones;

    public TextMesh resistenciaTotal;
    private string nombreResistencia;
    private float resistencia;
    private bool circuitoFinalizado;

    public int conexiones;
    public List<GameObject> resistencias;

    void Start()
    {
        numeroConexiones = 0;
        resistenciasTocadas = new List<GameObject>();

        this.resistencia = 0.000f;
        this.nombreResistencia = "";
        this.circuitoFinalizado = false;
        this.resistenciaTotal.text = resistencia.ToString("0.000");

    }

    
    void Update()
    {
        this.conexiones = numeroConexiones;
        this.resistencias = resistenciasTocadas;

        bool validacionExistenciaResistencia = validarExistenciaResistencia();

        if (numeroConexiones == 3 && validacionExistenciaResistencia && !circuitoFinalizado)
        {
            bool resistenciaConectada = resistenciasTocadas[0].GetComponentInParent<PosicionResistenciaL4P3>().conectado;

            if (resistenciaConectada)
            {
                valorResistencia(nombreResistencia);
                this.resistenciaTotal.text = resistencia.ToString("0.000");
                this.circuitoFinalizado = true;
            }
        }
        else if((numeroConexiones != 3 || !validacionExistenciaResistencia) && circuitoFinalizado)
        {
            this.resistencia = 0.000f;
            this.resistenciaTotal.text = resistencia.ToString("0.000");
            this.circuitoFinalizado = false;
        }

    }

    private bool validarExistenciaResistencia()
    {
        if (resistenciasTocadas.Count==2)
        {
            string nombreResistencia1 = resistenciasTocadas[0].name;
            string nombreResistencia2 = resistenciasTocadas[1].name;

            if ((nombreResistencia1.Equals("PataResitorUno", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorDos", StringComparison.OrdinalIgnoreCase))
                || (nombreResistencia1.Equals("PataResitorDos", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorUno", StringComparison.OrdinalIgnoreCase)))
            {
                this.nombreResistencia = "Resistencia560";
                return true;
            }
            else if ((nombreResistencia1.Equals("PataResitorTres", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorCuatro", StringComparison.OrdinalIgnoreCase))
                || (nombreResistencia1.Equals("PataResitorCuatro", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorTres", StringComparison.OrdinalIgnoreCase)))
            {
                this.nombreResistencia = "Resistencia560Dos";
                return true;
            }
            else if ((nombreResistencia1.Equals("PataResitorCinco", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorSeis", StringComparison.OrdinalIgnoreCase))
                || (nombreResistencia1.Equals("PataResitorSeis", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorCinco", StringComparison.OrdinalIgnoreCase)))
            {
                this.nombreResistencia = "Resistencia1K";
                return true;
            }
            else if ((nombreResistencia1.Equals("PataResitorSiete", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorOcho", StringComparison.OrdinalIgnoreCase))
                || (nombreResistencia1.Equals("PataResitorOcho", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorSiete", StringComparison.OrdinalIgnoreCase)))
            {
                this.nombreResistencia = "Resistencia1KDos";
                return true;
            }
            else if ((nombreResistencia1.Equals("PataResitorNueve", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorDiez", StringComparison.OrdinalIgnoreCase))
                || (nombreResistencia1.Equals("PataResitorDiez", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorNueve", StringComparison.OrdinalIgnoreCase)))
            {
                this.nombreResistencia = "Resistencia10K";
                return true;
            }
            else if ((nombreResistencia1.Equals("PataResitorOnce", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorDoce", StringComparison.OrdinalIgnoreCase))
                || (nombreResistencia1.Equals("PataResitorDoce", StringComparison.OrdinalIgnoreCase) && nombreResistencia2.Equals("PataResitorOnce", StringComparison.OrdinalIgnoreCase)))
            {
                this.nombreResistencia = "Resistencia4.7K";
                return true;
            }
        }

        this.nombreResistencia = "";
        return false;
    }

    private void valorResistencia(String nombreResistencia)
    {
        int aleatorio = UnityEngine.Random.Range(1,5);

        switch (nombreResistencia)
        {
            case "Resistencia560":
                switch (aleatorio)
                {
                    case 1:
                        this.resistencia = 0.558F;
                        break;
                    case 2:
                        this.resistencia = 0.559F;
                        break;
                    case 3:
                        this.resistencia = 0.561F;
                        break;
                    case 4:
                        this.resistencia = 0.562F;
                        break;
                }
                break;
            case "Resistencia560Dos":
                switch (aleatorio)
                {
                    case 1:
                        this.resistencia = 0.558F;
                        break;
                    case 2:
                        this.resistencia = 0.559F;
                        break;
                    case 3:
                        this.resistencia = 0.561F;
                        break;
                    case 4:
                        this.resistencia = 0.562F;
                        break;
                }
                break;
            case "Resistencia1K":
                switch (aleatorio)
                {
                    case 1:
                        this.resistencia = 0.998F;
                        break;
                    case 2:
                        this.resistencia = 0.999F;
                        break;
                    case 3:
                        this.resistencia = 1.001F;
                        break;
                    case 4:
                        this.resistencia = 1.002F;
                        break;
                }
                break;
            case "Resistencia1KDos":
                switch (aleatorio)
                {
                    case 1:
                        this.resistencia = 0.998F;
                        break;
                    case 2:
                        this.resistencia = 0.999F;
                        break;
                    case 3:
                        this.resistencia = 1.001F;
                        break;
                    case 4:
                        this.resistencia = 1.002F;
                        break;
                }
                break;
            case "Resistencia10K":
                switch (aleatorio)
                {
                    case 1:
                        this.resistencia = 9.998F;
                        break;
                    case 2:
                        this.resistencia = 9.999F;
                        break;
                    case 3:
                        this.resistencia = 10.001F;
                        break;
                    case 4:
                        this.resistencia = 10.002F;
                        break;
                }
                break;
            case "Resistencia4.7K":
                switch (aleatorio)
                {
                    case 1:
                        this.resistencia = 4.698F;
                        break;
                    case 2:
                        this.resistencia = 4.699F;
                        break;
                    case 3:
                        this.resistencia = 4.701F;
                        break;
                    case 4:
                        this.resistencia = 4.702F;
                        break;
                }
                break;
        }
    }

}
