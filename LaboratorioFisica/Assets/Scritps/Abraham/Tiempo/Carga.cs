using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Carga : MonoBehaviour
{
    //Hice lo que pude para lo del 0, pero algo o no esta bien configurado o me falta algo.
    //Del resto esta todo bien.
    public bool modoCarga {get; set;}

    public double resistenciaC;
        
    private double tiempo;

    public TextMesh textoTiempo;

    public TextMesh textoVoltaje;

    public TextMesh textoCorriente;

    public TextMesh textoGeneral;

    private bool estado;

    private bool general;

    private double tiempoMax;

    public double voltajeC;

    public double corrienteI;

    public double capacitor;

    private double e;

    private double tiempoMin;

    public Button botonCarga;

    public Button botonDescarga;

    bool cuentaTerminada;
    // Start is called before the first frame update
    void Start()
    {

        e=2.71828;

        tiempo=0;

        tiempoMin = 0;

        tiempoMax = resistenciaC * capacitor;

        modoCarga=true;
        cuentaTerminada =true;

    }

    // Update is called once per frame
    void Update()
    {
        bool conVoltaje= GestorCircuito.instance.voltajeListo;


        if(general == true){

            //Para mostrar el Voltaje en V.
           // Debug.Log("Voltaje");
            textoGeneral.text ="" + voltajeC  ;
        // }else if(general == false) {
        }else {
            //Debug.Log("corriente");
            //Para mostrar la corriente en I.
            textoGeneral.text ="" + corrienteI ;

        }

        
        if(conVoltaje){
            if(modoCarga){
            if(estado){

                if(tiempo >= tiempoMax-0.1 ){
                    if(!cuentaTerminada){
                        cuentaTerminada=true;
                         Debug.Log("Termino la carga");
                    
                        if(botonCarga!=null || botonDescarga!=null){
                            botonCarga.interactable=false;
                            botonDescarga.interactable=true;
                            StartCoroutine(margenDesactivacion());
                        }
                
                    }
                   
                    
                    

                }
                if(tiempo==tiempoMax){
                    tiempo++;
                }

                if(tiempo<=tiempoMax){
                    if(cuentaTerminada){
                        cuentaTerminada=false;
                    }
                    //Debug.Log(tiempo+"  Tiempo transcurrido");
                    //Debug.Log(tiempoMax + "  Tiempo maximo");
                    
                    tiempo += Time.deltaTime;

                    tiempo = Math.Round(tiempo,2);

                    textoTiempo.text = tiempo.ToString();

                    double valor = Math.Pow( (1/e) , (tiempo / (resistenciaC * capacitor ) ) ) ;

                    voltajeC = SumaRestar.resultado*( 1 - valor ) ;

                    voltajeC = Math.Round(voltajeC, 2);

                    textoVoltaje.text = "Voltaje:" + voltajeC ;

                    corrienteI = ( SumaRestar.resultado / resistenciaC) * valor ; 

                    corrienteI = Math.Round(corrienteI, 5);

                    textoCorriente.text = "Corriente:" + corrienteI ;

                }

            }
        }else{
            if(estado){
                if(tiempo<=tiempoMin+0.2){
                    if(!cuentaTerminada){
                        cuentaTerminada=true;
                        Debug.Log("Termino la descarga");
                        if(botonCarga!=null || botonDescarga!=null){
                            botonCarga.interactable=true;
                            botonDescarga.interactable=false;
                            StartCoroutine(margenDesactivacion());
                            //textoGeneral.text ="" + 0.00 ;
                        }
                    }
                    
                    //textoTiempo.text = ""+0.00;
                }

                if(tiempoMin<=tiempo){
                    if(cuentaTerminada){
                        cuentaTerminada=false;
                    }
                    
                    tiempo -= Time.deltaTime;

                    tiempo = Math.Round(tiempo,2);

                    if(tiempo==0){
                       
                        textoTiempo.text = ""+0.00;

                    }else{

                        textoTiempo.text = tiempo.ToString();

                    }


                    double valor = Math.Pow( (1/e) , (tiempo / (resistenciaC * capacitor ) ) ) ;

                    voltajeC = SumaRestar.resultado*( 1 - valor ) ;

                    voltajeC = Math.Round(voltajeC, 2);

                    if(voltajeC<=0){
                        //textoGeneral.text ="" + 0.00 ;
                        textoVoltaje.text = "Voltaje:" + 0.00 ;

                    }else{
                        
                        textoVoltaje.text = "Voltaje:" + voltajeC ;

                    }

                    corrienteI = ( SumaRestar.resultado / resistenciaC) * valor ; 

                    corrienteI = Math.Round(corrienteI, 5);

                    if(corrienteI<=0){
                        //textoGeneral.text ="" + 0.00 ;
                        textoCorriente.text = "Corriente:" + 0.00 ;

                    }else{

                        textoCorriente.text = "Corriente:" + corrienteI ;

                    }

                }

            }else{
                
                if(corrienteI<=0){
                    //textoGeneral.text ="" + 0.00 ;
                    textoCorriente.text = "Corriente:" + 0.00 ;
                    //textoGeneral.text = ""+0.00;

                }

                if(voltajeC<=0){
                    //textoGeneral.text ="" + 0.00 ;
                    textoVoltaje.text = "Voltaje:" + 0.00 ;
                    //textoGeneral.text = ""+0.00;

                }
            }
        }
        }else{
            SumaRestar.resultado=0.00;
            tiempo=0;
            tiempoMin = 0;
            botonCarga.interactable=false;
            botonDescarga.interactable=false;
            textoGeneral.text ="" + 0.00 ;
            estado=false;
            if(estado){
                estado=false;
            }
            voltajeC=0.00;
            corrienteI=0.00;
            //GestorCircuito.instance.circuitoConstruidoAlimentacion=false;
        }
        
        
    }

    public void Empezar(){

        estado = !estado;

    }

    public void MandarEstado(bool status){

        estado = status;


    }

    /*
    public void CambiarCargaDescarga(){
        if(modoCarga)
        {
            modoCarga=false;
        }else{
            modoCarga=true;
        }
    }
    */

    public void ModoCarga(){
        modoCarga=true;
    }

    public void ModoDescarga(){
        modoCarga=false;
    }
    

    public void CambiarTrueGeneral(){

        if(general == true){

            general = false;

        }else if(general == false){

            general = true;

        }


    }

    IEnumerator margenDesactivacion(){
        yield return new WaitForSeconds(0.5f);
        estado=false;
    }


}
