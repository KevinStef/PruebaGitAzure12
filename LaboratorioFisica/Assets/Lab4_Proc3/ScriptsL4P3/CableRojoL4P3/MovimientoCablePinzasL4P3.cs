using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoCablePinzasL4P3 : MonoBehaviour
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
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z-0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorDos", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorTres", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorCuatro", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorCinco", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorSeis", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorSiete", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorOcho", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorNueve", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorDiez", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorOnce", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("PataResitorDoce", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = false;

                Vector3 pataResistorPosition = other.transform.position;
                mySequence.Append(objetoCogible.transform.DOMove(new Vector3(pataResistorPosition.x, pataResistorPosition.y, pataResistorPosition.z - 0.15f), 0.6f));

                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.resistenciasTocadas.Add(other.gameObject);

                imagen.color = Color.green;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("PataResitorUno", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorDos", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorTres", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorCuatro", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorCinco", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorSeis", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorSiete", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorOcho", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorNueve", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorDiez", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorOnce", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("PataResitorDoce", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableRojoL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresPataL4P3>().nombreObjetoConectado = "";

                int indice = CircuitoTerminadoL4P3.resistenciasTocadas.FindIndex(x => x.Equals(other.gameObject));
                CircuitoTerminadoL4P3.resistenciasTocadas.RemoveAt(indice);

                imagen.color = Color.red;
            }
        }
    }
}
