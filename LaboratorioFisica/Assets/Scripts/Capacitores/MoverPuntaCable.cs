using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverPuntaCable : MonoBehaviour
{
    Transform lugar;

    
    bool insertado;

    public Vector3 destino;

    public Vector3 rotacionInsertado;

    public Vector3 posicionNuevoNegativo;

    public Vector3 rotacionNuevoNegativo;

    Vector3 posicionInicial;

    Vector3 rotacionInicial;
    Sequence secuencia;

    float contadorPosicionNegativo;

    // Al ser una parte nada más del todo, obtengo la posicion del padre.
    void Start()
    {
        insertado=false;
        //lugar = gameObject.transform;
        lugar = transform.parent;

        //posicionInicial = lugar.position;
        posicionInicial = lugar.localPosition;
        //rotacionInicial = lugar.eulerAngles;
        rotacionInicial = lugar.localEulerAngles;
    }


    public void Mover()
    {
        //Revisa si hay un capacitor conectado al protoboard.
        bool listoConectar=AdminCapacitores.instance.capacitorPosicionado;

        if(listoConectar)
        {

            
            secuencia = DOTween.Sequence();

            //Esta parte es para desconectar
            if(insertado){
                if(gameObject.CompareTag("CocodriloNegativo")){
                   
                }else{
                    AdminCapacitores.instance.DesconexionCable();
                    GestorCircuito.instance.DesconexionCircuito();
                }
                insertado=false;
                
                secuencia.Append(lugar.DOLocalMove(posicionInicial,1f))
                        .Join(lugar.DOLocalRotate(rotacionInicial,0.5f));
                


            //Esta parte es para conectar
            }else{
                if(gameObject.CompareTag("CocodriloNegativo")){
                    contadorPosicionNegativo++;
                    if(contadorPosicionNegativo==1){
                        AdminCapacitores.instance.ConexionCable();
                        GestorCircuito.instance.ConstruccionCircuito();
                        secuencia.Append(lugar.DOLocalMove(destino,1f))
                            .Join(lugar.DOLocalRotate(rotacionInsertado,0.5f));
                    }
                    if(contadorPosicionNegativo>=2){

                        insertado=true;
                        AdminCapacitores.instance.DesconexionCable();
                        GestorCircuito.instance.DesconexionCircuito();
                        GestorCircuito.instance.ConexionCapacitor();
                        secuencia.Append(lugar.DOLocalMove(posicionNuevoNegativo,1f))
                                .Join(lugar.DOLocalRotate(rotacionNuevoNegativo,0.5f));
                        contadorPosicionNegativo=0;

                    }
                }else{
                    /**/
                    insertado=true;
                    AdminCapacitores.instance.ConexionCable();
                    GestorCircuito.instance.ConstruccionCircuito();
                    secuencia.Append(lugar.DOLocalMove(destino,1f))
                        .Join(lugar.DOLocalRotate(rotacionInsertado,0.5f));
                }
                /*
                insertado=true;
                AdminCapacitores.instance.ConexionCable();
                GestorCircuito.instance.ConstruccionCircuito();
                secuencia.Append(lugar.DOLocalMove(destino,1f))
                        .Join(lugar.DOLocalRotate(rotacionInsertado,0.5f));

                */
               
            }
        }else{
            if(gameObject.CompareTag("CocodriloNegativo")){
                if(insertado){
                    GestorCircuito.instance.DesconexionCapacitor();
                    insertado=false;
                    secuencia.Append(lugar.DOLocalMove(posicionInicial,1f))
                        .Join(lugar.DOLocalRotate(rotacionInicial,0.5f));
                }
            }
        }
        
    }

    
}
