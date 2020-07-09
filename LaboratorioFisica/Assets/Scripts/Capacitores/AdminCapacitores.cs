using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminCapacitores : MonoBehaviour
{
    public static AdminCapacitores instance= null;
    public bool cablesConectados {get;set;}

    public bool capacitorPosicionado {get; set;}

    public float cantidadCablesConectados{get; set;}

    public bool circuitoCompleto {get; set;}

    public float idCapacitor{get;set;}

    Coroutine deteccionCircuito;

    public float conexionesMultimetro {get; set;}

    // Start is called before the first frame update
    void Start()
    {
        cablesConectados=false;
        capacitorPosicionado=false;
        if(instance == null)
        {
            instance=this;
        }else if(instance!=this)
        {
            Destroy(gameObject);
        }
        //Esta cantidad representa las conexiones al capacitor.
        cantidadCablesConectados=0;

        //Detector Universal si el circuito es completo o no.
        circuitoCompleto=false;

        //Esta cantidad representa las conexiones al Multimetro.
        conexionesMultimetro = 0;


        //Lo se, estoy sin ideas. Si alguno tiene una idea más optima (de haberlo) lo implementa.
    }

    void Update()
    {
        
    }
    public void ConexionMultimetro()
    {  
        conexionesMultimetro++;
        if(conexionesMultimetro>=2 && cantidadCablesConectados>=2){
            circuitoCompleto=true;
            //deteccionCircuito=StartCoroutine(EsperaConexion());
        }
    }

    public void DesconexionMultimetro()
    {
        conexionesMultimetro--;
       if(conexionesMultimetro==1)
       {
           //circuitoCompleto=false;
           if(deteccionCircuito!=null){
                StopCoroutine(deteccionCircuito);
            }
           circuitoCompleto=false;
       }
    }
    public void ConexionCable()
    {
        cantidadCablesConectados++;
        if(cantidadCablesConectados>0)
        {
            cablesConectados=true;
            if(cantidadCablesConectados>=2 && conexionesMultimetro>=2)
            {
                // Habra un tiempo de gracia para que se conecte todo el circuito.
                deteccionCircuito=StartCoroutine(EsperaConexion());
            }
        }
    }

    public void DesconexionCable(){
        cantidadCablesConectados--;
        if(cantidadCablesConectados==1)
        {
            if(deteccionCircuito!=null){
                StopCoroutine(deteccionCircuito);
            }
            circuitoCompleto=false;

        }else if(cantidadCablesConectados<1)
        {
            cablesConectados=false;
        }
    }


    IEnumerator EsperaConexion(){
        // Nota: el tiempo debe coincidir con el tiempo que se demora la punta en terminar la animación.
        yield return new WaitForSeconds(1f);

        circuitoCompleto=true;
    }
}
