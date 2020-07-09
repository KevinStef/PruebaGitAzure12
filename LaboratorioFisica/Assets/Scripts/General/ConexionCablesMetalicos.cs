using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConexionCablesMetalicos : MonoBehaviour
{
    // Esto es para conectar los cables metalicos para el circuito completo.
    // Y al parecer tambien para las resistencias.
    // No pregunten por que lo descubri muy tarde.

    public Vector3 posicionConexion;

    public Vector3 rotacionConexion;

    Transform ubicacionObjeto;

    Vector3 posicionInicial;

    Vector3 rotacionInicial;

    Sequence secuencia;
    bool conectado;
    // Start is called before the first frame update
    void Start()
    {
        ubicacionObjeto = gameObject.transform.parent;
        posicionInicial = ubicacionObjeto.position;
        rotacionInicial = ubicacionObjeto.eulerAngles;
        conectado = false;
    }


    public void ConexionCircuito()
    {
        secuencia = DOTween.Sequence();
        if(!conectado)
        {
            GestorCircuito.instance.ConstruccionCircuito();
            if(gameObject.CompareTag("Resistor"))
            {
                GestorCircuito.instance.ConexionCapacitor();
            }
            conectado = true;
            secuencia.Append(ubicacionObjeto.DOMove(posicionConexion,0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionConexion,0.5f));

        }else{
            if(gameObject.CompareTag("Resistor"))
            {
                GestorCircuito.instance.DesconexionCapacitor();
            }
            GestorCircuito.instance.DesconexionCircuito();
            conectado = false;
            secuencia.Append(ubicacionObjeto.DOMove(posicionInicial,0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionInicial,0.5f));
        }
    }
}
