using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Conexioncables : MonoBehaviour
{
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
        ubicacionObjeto = gameObject.transform;
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
            if (gameObject.CompareTag("CableRojo"))
            {
                GestorResistor.instance.CableProtoRojo();
            }

            if (gameObject.CompareTag("CableAzul"))
            {
                GestorResistor.instance.CableProtoAzul();
            }

            GestorResistor.instance.ConstruccionCircuito();
            conectado = true;
            secuencia.Append(ubicacionObjeto.DOMove(posicionConexion, 0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionConexion, 0.5f));

        }
        else
        {
            if (gameObject.CompareTag("CableRojo"))
            {
                GestorResistor.instance.CableProtoRojoRes();
            }
            if (gameObject.CompareTag("CableAzul"))
            {
                GestorResistor.instance.CableProtoAzulRes();
            }
            GestorResistor.instance.DesconexionCircuito();
            conectado = false;
            secuencia.Append(ubicacionObjeto.DOMove(posicionInicial, 0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionInicial, 0.5f));
        }
    }
}
