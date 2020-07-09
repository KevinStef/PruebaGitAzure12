using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverResistencia : MonoBehaviour
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

            if(gameObject.CompareTag("Re470")){

                GestorMovimiento.instance.sumarResistencia470();
                GestorMovimiento.instance.sumarConexionIndirecta1();
                GestorMovimiento.instance.sumarConexionDirecta1();

            }

            if(gameObject.CompareTag("Re1K1")){

                GestorMovimiento.instance.sumarResistencia1();
                GestorMovimiento.instance.sumarConexionIndirecta1();
                GestorMovimiento.instance.sumarConexionDirecta1();

            }

            if(gameObject.CompareTag("Re10K")){

                GestorMovimiento.instance.sumarResistencia10();
                GestorMovimiento.instance.sumarConexionIndirecta1();
                GestorMovimiento.instance.sumarConexionDirecta1();

            }

            if(gameObject.CompareTag("Re560")){

                GestorMovimiento.instance.sumarResistencia560();
                GestorMovimiento.instance.sumarConexionIndirecta1();
                GestorMovimiento.instance.sumarConexionDirecta1();

            }

            GestorMovimiento.instance.ConstruccionCircuito();
            conectado = true;
            secuencia.Append(ubicacionObjeto.DOMove(posicionConexion, 0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionConexion, 0.5f));
                    
            //Sumamos 1 cada ves que movemos a la posicion deseada y en el else restamos 1
            VariablesGlobales.NumeroCondicion++;
        }
        else
        {

            if(gameObject.CompareTag("Re470")){

                GestorMovimiento.instance.restarResistencia470();
                GestorMovimiento.instance.restarConexionDirecta1();
                GestorMovimiento.instance.restarConexionIndirecta1();

            }

            if(gameObject.CompareTag("Re1K1")){

                GestorMovimiento.instance.restarResistencia1();
                GestorMovimiento.instance.restarConexionDirecta1();
                GestorMovimiento.instance.restarConexionIndirecta1();

            }

            if(gameObject.CompareTag("Re10K")){

                GestorMovimiento.instance.restarResistencia10();
                GestorMovimiento.instance.restarConexionDirecta1();
                GestorMovimiento.instance.restarConexionIndirecta1();

            }

            if(gameObject.CompareTag("Re560")){

                GestorMovimiento.instance.restarResistencia560();
                GestorMovimiento.instance.restarConexionDirecta1();
                GestorMovimiento.instance.restarConexionIndirecta1();

            }

            GestorMovimiento.instance.DesconexionCircuito();
            conectado = false;
            secuencia.Append(ubicacionObjeto.DOMove(posicionInicial, 0.5f))
                    .Join(ubicacionObjeto.DORotate(rotacionInicial, 0.5f));

            //Restamos 1 cada ves que movemos a la posicion inicial el objeto
            VariablesGlobales.NumeroCondicion--;

        }
    }

}