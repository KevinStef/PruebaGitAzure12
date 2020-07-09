using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConexionAlimentador : MonoBehaviour
{

    public Transform puntoAlcance;

    Transform posicionConector;

    Vector3 posicionInicial;

    Vector3 rotacionInicial;

    Sequence secuencia;

    bool conectado;
    // Start is called before the first frame update
    void Start()
    {
        posicionConector =transform.parent;
        posicionInicial = posicionConector.localPosition;
        rotacionInicial = posicionConector.localEulerAngles;
        conectado = false;
    }

    public void Conexion(){
        secuencia = DOTween.Sequence();
        if(!conectado)
        {
            if(gameObject.CompareTag("CablePositivo"))
            {
                bool ocupado = GestorCircuito.instance.positivoOcupado;
                if(!ocupado){
                    GestorCircuito.instance.positivoOcupado=true;
                    conectado = true;
                    secuencia.Append(posicionConector.DOMove(puntoAlcance.position,1f))
                        .Join(posicionConector.DORotate(puntoAlcance.eulerAngles,0.5f));
                }
            }else{
                conectado = true;
                secuencia.Append(posicionConector.DOMove(puntoAlcance.position,1f))
                    .Join(posicionConector.DORotate(puntoAlcance.eulerAngles,0.5f));
            }
            

        }else{
            if(gameObject.CompareTag("CablePositivo"))
            {
                GestorCircuito.instance.positivoOcupado=false;
            }
            conectado = false;
            secuencia.Append(posicionConector.DOLocalMove(posicionInicial,1f))
                    .Join(posicionConector.DOLocalRotate(rotacionInicial,0.5f));
        }
    }
}
