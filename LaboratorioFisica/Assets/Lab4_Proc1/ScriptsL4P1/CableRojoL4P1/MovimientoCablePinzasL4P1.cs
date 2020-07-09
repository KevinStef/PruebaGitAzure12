using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoCablePinzasL4P1 : MonoBehaviour
{

    public Image imagen;

    public GameObject objetoCogible;
    Sequence mySequence;
    void Start()
    {
        mySequence = DOTween.Sequence();
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("PataResitorUno", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P1>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z-0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P1.numeroConexiones++;

                imagen.color = Color.green;

            }
        }
        else if (other.name.Equals("PataResitorDos", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P1>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P1.numeroConexiones++;

                imagen.color = Color.green;

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("PataResitorUno", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P1>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado = "";

                CircuitoTerminadoL4P1.numeroConexiones--;

                imagen.color = Color.red;

            }
        }
        else if (other.name.Equals("PataResitorDos", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P1>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P1>().nombreObjetoConectado = "";

                CircuitoTerminadoL4P1.numeroConexiones--;

                imagen.color = Color.red;

            }
        }
    }
}
