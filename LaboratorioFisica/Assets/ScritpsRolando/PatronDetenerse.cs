using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronDetenerse : MonoBehaviour
{
    // Public variables
    public GameObject ObjetoActivador;  
    public float TiempoAntesDeAccion;
    public float TiempoDeTraslado;

    // Private variables
    private float timeToStart;
    private float timeToTranslate;
    private bool workDone = false;

    //Public variable
    private bool ejecucionTerminada;

    void Start()
    {
        // Justo al inicio deshabilitamos el script (será activado por el script 
        // 'ComportamientoPatron.cs' cuando el objeto activador llegue al hito)
        this.enabled = false;

        timeToStart = 0;
        timeToTranslate = 0;
        workDone = false;

        ejecucionTerminada = false;
    }


    void Update()
    {
        ObjetoActivador.GetComponent<Rigidbody>().isKinematic = true;
        if (!workDone)
        {

            timeToStart += Time.deltaTime;

            // No realizamos la acción hasta que no pase el tiempo 'TiempoAntesDeAccion'
            if (timeToStart >= TiempoAntesDeAccion)
            {
                // IMPLEMENTACIÓN DE LA ACCIÓN...
                // ...

                workDone = true;
            }
        }
        else
        {
            timeToTranslate += Time.deltaTime;

            //No avanzamos al siguiente hito hasta que no pase el tiempo 'TiempoDespuesDeAccion'
            if (timeToTranslate >= TiempoDeTraslado)
            {
                // Se inicializa el script
                Start();

                // Indicamos que el objeto se detendrá en el hito posicionado en el agujero

                ejecucionTerminada = true;

                ObjetoActivador.GetComponentInParent<ComportamientoPatron>().CanGoToNextMilestone = false;
            }
        }
    }

    public bool EjecucionTerminada()
    {
        return ejecucionTerminada;
    }

}
