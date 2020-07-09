using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarMovimientoCondensador : MonoBehaviour
{

    public GameObject condensador;

    public GameObject hitoResponsable1;

    public GameObject hitoResponsable2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    void OnMouseDown()
    {
        condensador.GetComponentInParent<ComportamientoPatron>().enabled = true;
        bool circuitoCompleto = condensador.GetComponentInParent<DetectarCircuitoTerminado>().circuitoCompleto;
            if (!circuitoCompleto)
            {
                if (hitoResponsable1.GetComponentInParent<PatronDetenerse>().EjecucionTerminada() && hitoResponsable2.GetComponentInParent<PatronDetenerse>().EjecucionTerminada())
                {
                    condensador.GetComponentInParent<ComportamientoPatron>().CanGoToNextMilestone = true;
                }
            }

            if (circuitoCompleto)
            {

                condensador.GetComponentInParent<ComportamientoPatron>().CanGoToNextMilestone = true;
                //condensador.GetComponentInParent<DetectarCircuitoTerminado>().colisiones = 0;
                condensador.GetComponentInParent<DetectarCircuitoTerminado>().circuitoCompleto = false;

            }

            
        


    }
    */
    
}
