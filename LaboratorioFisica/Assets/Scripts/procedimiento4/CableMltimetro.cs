using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Collections.Specialized;

public class CableMltimetro : MonoBehaviour
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
            GestorResistor.instance.ConstruccionCircuito();
            conectado = true;
            secuencia.Append(ubicacionObjeto.DOMove(posicionConexion, 0.5f));
            //.Join(ubicacionObjeto.DORotate(rotacionConexion, 0.5f));
        }
        else
        {
            GestorResistor.instance.DesconexionCircuito();
            conectado = false;
            secuencia.Append(ubicacionObjeto.DOMove(posicionInicial, 0.5f));
            //.Join(ubicacionObjeto.DORotate(rotacionInicial, 0.5f));
        }
    }

    /*public GameObject cableRojoCabeza;
    Sequence secuencia;
    void Start()
    {
        secuencia= DOTween.Sequence();
    }
    private void OnMouseDown()
    {
        secuencia.Append(cableRojoCabeza.transform.DOLocalMove(new Vector3(0.0877f, 4.454283e-05f, 0f),4f));
    }*/

}









