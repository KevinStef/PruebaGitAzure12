using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentandoVoltaje : MonoBehaviour
{
    public float velocidadAlAumentar;
    public float maximoValorVoltaje;
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
        if (voltajeTotal < maximoValorVoltaje)
        {
            this.voltajeTotal += 0.03F * Time.deltaTime * velocidadAlAumentar;
            MostrandoVoltaje.modificarTotalVoltaje(voltajeTotal);
        }
    }
}
