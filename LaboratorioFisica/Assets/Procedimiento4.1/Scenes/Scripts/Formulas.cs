using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formulas : MonoBehaviour
{
    public GameObject boton;
    private bool presionado;
    public TextMesh MostrarMulti;
    private bool conectado1;
    private bool conectado2;
    private bool conectado3;
    private bool conectado4;

    private float tolerancia;
    
    void Start()
    {   
        this.presionado = boton.GetComponent<PresionDeBoton>().estaPresionado();
        retornarTolerancia();
    }

    public void retornarTolerancia(){

        tolerancia = UnityEngine.Random.Range(95f,105f) ;
        tolerancia = tolerancia / 100 ;

    }

    void Update()
    {
        conectado1 = ConexionCables.conectado;

        conectado2 = ConexionCables.conectado2;

        conectado3 = ConexionCables.conectado3;

        conectado4 = ConexionCables.conectado4;


        this.presionado = boton.GetComponent<PresionDeBoton>().estaPresionado();

        if(VariablesGlobales.NumeroCondicion==9 && conectado1 && conectado2 && MovimientoPerillaMultimetro.indiceMultimetro == 4){

            double sumaResistencia = ((10000*tolerancia)+(1000*tolerancia)+(1000*tolerancia)+(560*tolerancia)+(470*tolerancia))/1000;
            sumaResistencia = Math.Round(sumaResistencia,2);
            MostrarMulti.text = ""+sumaResistencia+"KΩ";

        }else if(VariablesGlobales.NumeroCondicion==11 && !presionado && MovimientoPerillaMultimetro.indiceMultimetro == 6 && !conectado1 && !conectado2){

            double sumaResistencia = (10000*tolerancia)+(1000*tolerancia)+(1000*tolerancia)+(560*tolerancia)+(470*tolerancia);
            double voltaje = MostrandoVoltaje.obtenerTotalVoltaje() ;
            double intensidadCorriente = (voltaje/sumaResistencia) ;
            intensidadCorriente = Math.Round(intensidadCorriente,5);
            MostrarMulti.text = ""+intensidadCorriente+"mA";

        }else if(VariablesGlobales.NumeroCondicion==0 && presionado){

            MostrarMulti.text = "";

        }else{

            MostrarMulti.text = "0.00";

        }
    }

}
