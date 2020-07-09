using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IniciarMovimiento : MonoBehaviour
{
    private int toque;

    public GameObject cable;

    public GameObject hitoResponsable;

    public GameObject hitoResponsableCondesador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (toque == 0)
        {
            cable.GetComponentInParent<ComportamientoPatron>().enabled = true;
            toque++;
        }
        else if(toque == 1 && hitoResponsable.GetComponentInParent<PatronDetenerse>().EjecucionTerminada() && hitoResponsableCondesador.GetComponentInParent<PatronDetenerse>().EjecucionTerminada())
        {
            cable.transform.GetChild(0).GetComponentInParent<ComportamientoPatron>().enabled = true;
            toque++;
        }
        

    }

}
