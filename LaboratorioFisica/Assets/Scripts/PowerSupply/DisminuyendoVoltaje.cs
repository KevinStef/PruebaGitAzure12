using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DisminuyendoVoltaje : MonoBehaviour
{
    public float velocidadAlDisminuir;
    public float minimoValorVoltaje;
    private float voltajeTotal;
    void Start()
    {
        this.voltajeTotal = MostrandoVoltaje.obtenerTotalVoltaje();
    }

    void Update()
    {
        this.voltajeTotal = MostrandoVoltaje.obtenerTotalVoltaje();
    }

    private void OnMouseDrag()
    {
        if (voltajeTotal > minimoValorVoltaje)
        {
            this.voltajeTotal -= 0.03F * Time.deltaTime * velocidadAlDisminuir;
            MostrandoVoltaje.modificarTotalVoltaje(voltajeTotal);
        }
    }
}
