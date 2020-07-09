using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConexionNormal : MonoBehaviour
{
    // Esta es la logica para las pinzas cocodrilo sin ninguna logica adicional.
    Transform posicionCable;

    public Vector3 posicionDestino;

    public Vector3 rotacionDestino;

    public Vector3 posicionNuevoNegativo;

    Vector3 posicionInicial;

    Vector3 rotacionInicial;

    
    Sequence secuencia;

    bool conectado;

    float contadorNegativo;

    void Start()
    {
        posicionCable = gameObject.transform.parent;
        posicionInicial = posicionCable.localPosition;
        rotacionInicial = posicionCable.localEulerAngles;
        conectado = false;

    }


    public void ConectarCircuito()
    {
        secuencia = DOTween.Sequence();
        if(!conectado)
        {
            if(gameObject.CompareTag("CocodriloNegativo")){
                contadorNegativo++;
                if(contadorNegativo==1){
                    GestorCircuito.instance.ConstruccionCircuito();
                    //Para ponerlo en el lugar original
                    secuencia.Append(posicionCable.DOLocalMove(posicionDestino,1f))
                        .Join(posicionCable.DOLocalRotate(rotacionDestino,0.5f,RotateMode.Fast));

                }
                if(contadorNegativo>=2){
                    
                    bool multimetroDetectado= AdminCapacitores.instance.capacitorPosicionado;
                    if(multimetroDetectado){
                        GestorCircuito.instance.ConexionCapacitor();
                        //Para ponerlo en el multimetro y luego declarar de que volvera a su punto de origen.
                        GestorCircuito.instance.DesconexionCircuito();
                        secuencia.Append(posicionCable.DOLocalMove(posicionNuevoNegativo,1f));
                        contadorNegativo=0;
                        conectado=true;
                        //Debug.Log(GestorCircuito.instance.conectadoAlimentador);
                    }
                  

                    //contadorNegativo=0;
                }

            }else{
                GestorCircuito.instance.ConstruccionCircuito();
                conectado = true;
                secuencia.Append(posicionCable.DOLocalMove(posicionDestino,1f))
                    .Join(posicionCable.DOLocalRotate(rotacionDestino,0.5f,RotateMode.Fast));
            }
           

        }else{
            if(gameObject.CompareTag("CocodriloNegativo")){
                GestorCircuito.instance.DesconexionCapacitor();
               
            }else{
                GestorCircuito.instance.DesconexionCircuito();
                
            }
            conectado = false;
            secuencia.Append(posicionCable.DOLocalMove(posicionInicial,1f))
                   .Join(posicionCable.DOLocalRotate(rotacionInicial,0.5f));
        }


    }
}
