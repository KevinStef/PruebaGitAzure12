using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronAnimacionCable : MonoBehaviour
{

    // Public variables
    public GameObject ObjetoActivador;
    public float TiempoAntesDeAccion;
    public float TiempoDeTraslado;

    public Animator animacionCabezaCable;

    // Private variables
    private float timeToStart;
    private float timeToTranslate;
    private bool workDone = false;

    void Start()
    {
        // Justo al inicio deshabilitamos el script (será activado por el script 
        // 'ComportamientoPatron.cs' cuando el objeto activador llegue al hito)
        this.enabled = false;

        timeToStart = 0;
        timeToTranslate = 0;
        workDone = false;

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
                animacionCabezaCable.SetBool("abrir", true);
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

                ObjetoActivador.GetComponentInParent<ComportamientoPatron>().CanGoToNextMilestone = true;
            }
        }
    }
}
