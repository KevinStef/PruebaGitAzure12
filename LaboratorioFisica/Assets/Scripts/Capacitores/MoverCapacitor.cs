using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverCapacitor : MonoBehaviour
{
    bool centrado;
    Transform posicionCapacitor;

    Vector3 posicionInicial;

    Vector3 rotacionInicial;

    public Vector3 posicionCentro;

    public Vector3 rotacionCentro;

    Sequence secuenciaMovimiento;

    public float identificadorCapacitor;
    // Al ser una parte nada más del todo, obtengo la posicion del padre.
    void Start()
    {
        centrado = false;
        
        //posicionCapacitor = GetComponentInParent<Transform>();
        posicionCapacitor = transform.parent;
        posicionInicial = posicionCapacitor.position;
        rotacionInicial = posicionCapacitor.rotation.eulerAngles;
    }



    public void MoverPosicion(){
        //Primero reviso las condiciones: si esta conectado a algun cable o si esta en posicion de conexion.
        bool conectado = AdminCapacitores.instance.cablesConectados;
        bool ocupado = AdminCapacitores.instance.capacitorPosicionado;
         bool conectadoAlimentado = GestorCircuito.instance.conectadoAlimentador;
        
        if(!conectado && !conectadoAlimentado){
            secuenciaMovimiento=DOTween.Sequence();
            if(!centrado){
                if(!ocupado)
                {
                    centrado=true;
                    secuenciaMovimiento
                        .Append(posicionCapacitor.DOMove(posicionCentro,0.5f))
                        .Join(posicionCapacitor.DORotate(rotacionCentro,0.5f));
                    
                    AdminCapacitores.instance.capacitorPosicionado=true;
                    AdminCapacitores.instance.idCapacitor = identificadorCapacitor;
                }
                
            }else{
                centrado=false;
                secuenciaMovimiento
                    .Append(posicionCapacitor.DOMove(posicionInicial,0.5f))
                    .Join(posicionCapacitor.DORotate(rotacionInicial,0.5f));
                AdminCapacitores.instance.capacitorPosicionado=false;
                AdminCapacitores.instance.idCapacitor = 0;
            }
        }
        
        
    }
}
