using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConectarMultimetro : MonoBehaviour
{
    Transform posicionCable;

    Sequence secuencia;

    public Transform[] ubicacionConector;

    Vector3 posicionInicial;

    bool conectado;

    int tipoConexionMultimetro;
    // Start is called before the first frame update
    void Start()
    {
        posicionCable = transform.parent;

        posicionInicial = posicionCable.localPosition;
        conectado = false;
        tipoConexionMultimetro = 0;
    }

    

    public void Conectar(){
        secuencia = DOTween.Sequence();

        //Para la desconexion
        if(conectado){
            
            conectado=false;
            tipoConexionMultimetro++;
            if(tipoConexionMultimetro>=2){
                tipoConexionMultimetro=0;
            }
            posicionCable.DOLocalMove(posicionInicial,1f);
            
            
           
        //Para la conexion
        }else{
            conectado=true;
            
            posicionCable.DOMove(ubicacionConector[tipoConexionMultimetro].position,1f);
            
        }

        //Debug.Log(tipoConexionMultimetro);

    }
}
