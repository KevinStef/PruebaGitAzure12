using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Conexion : MonoBehaviour
{
    public Vector3 posicionConexion;
    public Vector3 rotacionConexion;
    Transform ubicacionObjeto;
    Vector3 posicionInicial;
    Vector3 rotacionInicial;
    Sequence secuencia;
    bool conectado;
    public int Resis560=0;

    // Start is called before the first frame update
    void Start()
    {
        ubicacionObjeto = gameObject.transform.parent;
        posicionInicial = ubicacionObjeto.position;
        rotacionInicial = ubicacionObjeto.eulerAngles;
        conectado = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void circuito()
    {
        secuencia = DOTween.Sequence();
        if (!conectado)
        {
            if(gameObject.CompareTag("Resis560k")){
                GestorResistor.instance.Resistencia560();
            }
            else if(gameObject.CompareTag("Resis1k")){
                GestorResistor.instance.Resistencia1();
            }
            else if(gameObject.CompareTag("Resis4.7k")){
                GestorResistor.instance.Resistencia47();
            }
            GestorResistor.instance.ConstruccionCircuito();
            conectado = true;
            secuencia.Append(ubicacionObjeto.DOMove(posicionConexion, 0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionConexion, 0.5f));

        }
        else
        {
            if(gameObject.CompareTag("Resis560k")){
                GestorResistor.instance.Resistencia560Res();
            }
            else if(gameObject.CompareTag("Resis1k")){
                GestorResistor.instance.Resistencia1Res();
            }
            else if(gameObject.CompareTag("Resis4.7k")){
                GestorResistor.instance.Resistencia47Res();
            }
            GestorResistor.instance.DesconexionCircuito();
            conectado = false;
            secuencia.Append(ubicacionObjeto.DOMove(posicionInicial, 0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionInicial, 0.5f));
        }
    }
}
