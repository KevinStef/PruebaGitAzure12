using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Descarga : MonoBehaviour
{

    public double resistenciaC;
        
    private double tiempo;

    public TextMesh textoTiempo;

    public TextMesh textoVoltaje;

    public TextMesh textoCorriente;

    public TextMesh textoGeneral;

    private bool estado;

    private bool general;

    private double tiempoMin;

    public double voltajeC;

    public double corrienteI;

    public double capacitor;

    private double e;

    // Start is called before the first frame update
    void Start()
    {

        e=2.71828;

        tiempo = resistenciaC * capacitor;

        tiempoMin = 0;

        general = true;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(general == true){    

            if(voltajeC<0){

                textoGeneral.text ="" + 0.00 ;

            }else{

                textoGeneral.text ="" + voltajeC  ;

            }

        }else if(general == false) {

            if(corrienteI<0){

                textoGeneral.text ="" + 0.00 ;

            }else{

                textoGeneral.text ="" + corrienteI ;

            }

        }

        if(estado){

            if(tiempoMin<=tiempo){

                tiempo -= Time.deltaTime;

                tiempo = Math.Round(tiempo,2);

                if(tiempo<0){

                    textoTiempo.text = ""+0.00;

                }else{

                    textoTiempo.text = tiempo.ToString();

                }

                double valor = Math.Pow( (1/e) , (tiempo / (resistenciaC * capacitor ) ) ) ;

                voltajeC = SumaRestar.resultado*( 1 - valor ) ;

                voltajeC = Math.Round(voltajeC, 2);

                if(voltajeC<0){

                    textoVoltaje.text = "Voltaje:" + 0.00 ;

                }else{

                    textoVoltaje.text = "Voltaje:" + voltajeC ;

                }

                corrienteI = ( SumaRestar.resultado / resistenciaC) * valor ; 

                corrienteI = Math.Round(corrienteI, 5);

                if(corrienteI<0){

                    textoCorriente.text = "Corriente:" + 0.00 ;

                }else{

                    textoCorriente.text = "Corriente:" + corrienteI ;

                }

            }

        }
        
    }
    
    public void Empezar(){

        estado = !estado;

    }

    /*public void MandarEstadoDescarga(bool status){

        estado = status;


    }*/

    public void CambiarTrueGeneral(){

        if(general == true){

            general = false;

        }else if(general == false){

            general = true;

        }


    }


}
