using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoCableNegroL4P3 : MonoBehaviour
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
        if (other.name.Equals("AgujeroUno", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = false;
                Transform hitoTresAgujero = other.gameObject.transform.GetChild(0);
                mySequence.Append(objetoCogible.transform.DOMove(hitoTresAgujero.position, 0.6f));

                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = objetoCogible.name;

                imagen.color = Color.green;
            }

        }
        else if (other.name.Equals("AgujeroDos", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = false;
                Transform hitoCuatroAgujero = other.gameObject.transform.GetChild(0);
                mySequence.Append(objetoCogible.transform.DOMove(hitoCuatroAgujero.position, 0.5f));

                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = objetoCogible.name;

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("AgujeroTres", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = false;
                Transform hitoCincoAgujero = other.gameObject.transform.GetChild(0);
                mySequence.Append(objetoCogible.transform.DOMove(hitoCincoAgujero.position, 0.5f));

                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = objetoCogible.name;

                imagen.color = Color.green;
            }
        }
        else if (other.name.Equals("AgujeroCuatro", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;
            if (nombreObjetoConectado.Equals("", System.StringComparison.OrdinalIgnoreCase))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = false;
                Transform hitoSeisAgujero = other.gameObject.transform.GetChild(0);
                mySequence.Append(objetoCogible.transform.DOMove(hitoSeisAgujero.position, 0.5f));

                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = objetoCogible.name;

                CircuitoTerminadoL4P3.numeroConexiones++;

                imagen.color = Color.green;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("AgujeroUno", System.StringComparison.OrdinalIgnoreCase))
        {
            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = "";

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("AgujeroDos", System.StringComparison.OrdinalIgnoreCase))
        {

            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = "";

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("AgujeroTres", System.StringComparison.OrdinalIgnoreCase))
        {

            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = "";

                imagen.color = Color.red;
            }
        }
        else if (other.name.Equals("AgujeroCuatro", System.StringComparison.OrdinalIgnoreCase))
        {

            string nombreObjetoConectado = other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado;

            if (objetoCogible.name.Equals(nombreObjetoConectado))
            {
                objetoCogible.GetComponent<MouseDragCableNegroL4P3>().tocarSuelo = true;
                other.gameObject.GetComponent<ControlConectoresAgujeroL4P3>().nombreObjetoConectado = "";

                CircuitoTerminadoL4P3.numeroConexiones--;

                imagen.color = Color.red;
            }
        }
    }
}
