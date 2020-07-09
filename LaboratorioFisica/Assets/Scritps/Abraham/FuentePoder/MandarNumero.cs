using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MandarNumero : MonoBehaviour
{
    public bool status;
    public Text valor;
    public Text voltaje;
    public Text intensidad;
    public TextMesh numeroV;
    public TextMesh numA;
    public TextMesh numR;
    public TextMesh numeros;



    public TextMesh intensidadCorriente;

    public string num;
    public string vol;
    public string amp;
    public static double numAmpers;

    //public static double numVol;
    //public static double resistencia;

    public Button botonActivar;




    void Start()
    {
         this.status = false;         
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void calcular()
    {
        num = valor.text;
        double resis = double.Parse(num);
        if (resis > 0)
        {
            //resistencia = resis;
            numR.text = "resistencia: " + num;
            SumaRestar.resistencia = resis;
        }
    }


    public void asignarvol()
    {
        //if (status) {
            vol = voltaje.text;
            double voltio = double.Parse(vol);
            if (voltio > 0)
            { 
                SumaRestar.resultado = voltio;
                numeros.text = "" + SumaRestar.resultado;
                botonActivar.interactable = true;
                GestorCircuito.instance.voltajeListo =true;
                //GetComponent<Carga>().MandarEstado(true);
                
            } 
        //}
    }


   public void asignarAmp()
    {
        amp = intensidad.text;
        double amperios = double.Parse(amp);
        if (amperios > 0)
        {
            numAmpers = amperios;
            numA.text = amp;
        }
    }


    /*public double mandarRes()
    {
        return resistencia;
    }*/

   
}
