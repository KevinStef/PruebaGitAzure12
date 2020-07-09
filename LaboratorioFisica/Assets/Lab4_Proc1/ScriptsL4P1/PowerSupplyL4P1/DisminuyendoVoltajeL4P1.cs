using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DisminuyendoVoltajeL4P1 : MonoBehaviour
{
    public float velocidadAlDisminuir;
    public float minimoValorVoltaje;
    private float voltajeTotal;
    void Start()
    {
        this.voltajeTotal = MostrandoVoltajeL4P1.obtenerTotalVoltaje();
    }

    void Update()
    {
        this.voltajeTotal = MostrandoVoltajeL4P1.obtenerTotalVoltaje();
    }

    private void OnMouseDrag()
    {
        if (voltajeTotal > minimoValorVoltaje)
        {
            this.voltajeTotal -= 0.01F * Time.deltaTime * velocidadAlDisminuir;
            MostrandoVoltajeL4P1.modificarTotalVoltaje(voltajeTotal);
        }
    }
}
