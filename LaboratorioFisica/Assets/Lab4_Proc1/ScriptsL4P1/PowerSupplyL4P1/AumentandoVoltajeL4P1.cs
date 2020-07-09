using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentandoVoltajeL4P1 : MonoBehaviour
{
    public float velocidadAlAumentar;
    public float maximoValorVoltaje;
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
        if (voltajeTotal < maximoValorVoltaje)
        {
            this.voltajeTotal += 0.01F * Time.deltaTime * velocidadAlAumentar;
            MostrandoVoltajeL4P1.modificarTotalVoltaje(voltajeTotal);
        }
    }
}
