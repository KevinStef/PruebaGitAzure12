using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CableDobleAlimentador : MonoBehaviour
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

    // Update is called once per frame
    public void ConexionDoble(){
        secuencia = DOTween.Sequence();
        if(!conectado)
        {
            if(gameObject.CompareTag("CableDoblePunta")){
                bool ocupado = GestorCircuito.instance.positivoOcupado;
                if(!ocupado){
                    GestorCircuito.instance.positivoOcupado=true;
                    conectado = true;
                    secuencia.Append(posicionConector.DOMove(puntoAlcance.position,1f))
                        .Join(posicionConector.DORotate(puntoAlcance.eulerAngles,0.5f));
                    GestorCircuito.instance.ConexionCapacitor();
                }

            }else{
                conectado = true;
                secuencia.Append(posicionConector.DOMove(puntoAlcance.position,1f))
                    .Join(posicionConector.DORotate(puntoAlcance.eulerAngles,0.5f));
                GestorCircuito.instance.ConexionCapacitor();
            }
            

        }else{
            if(gameObject.CompareTag("CableDoblePunta")){
                GestorCircuito.instance.positivoOcupado=false;
            }
            GestorCircuito.instance.DesconexionCapacitor();
            conectado = false;
            secuencia.Append(posicionConector.DOLocalMove(posicionInicial,1f))
                    .Join(posicionConector.DOLocalRotate(rotacionInicial,0.5f));
        }
    }
}
