using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConectarPuntoMultimetro : MonoBehaviour
{

    bool conectado;

    Vector3 posicionConectorInicial;

    public Transform posicionNueva;

    DetectarCircuitoTerminado detector;

    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponentInParent<DetectarCircuitoTerminado>();
    }


    public void Conectar(Transform objeto){
        
        if(!conectado)
        {
            if(posicionConectorInicial==null)
            {
                posicionConectorInicial = objeto.localPosition; 
            }
            //detector.cablesConectados++;
            conectado=true;
            objeto.DOMove(posicionNueva.position,1f);

        }else{
            conectado=false;
            //detector.cablesConectados--;
            objeto.DOMove(posicionConectorInicial,1f);
        }
    }
}
