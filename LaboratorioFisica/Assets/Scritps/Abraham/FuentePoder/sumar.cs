using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class sumar : MonoBehaviour
{

    public bool status;

    private double contador;

    public TextMesh numeros;

    public TextMesh intensidadC;

    public float velocidad;

    void Start()
    {
        this.status=false;
        
    }

    void Update()
    {
        
    }

    /*public void metodo(){

        numeros.text =  "1";

    }*/


    //para presionar solo una ves OnMouseDown,OnMouseUpAsButton,OnMouseUp
    //mantener encima del boton para que repita la accion OnMouseOver
    //mantener presionado pero con clik para que repita la accion OnMouseDrag
    void OnMouseDrag(){

        if(status){
   
        //contador = contador+0.01f ;

        //contador = Math.Round(contador,2);

        //numeros.text = (contador).ToString("#.##") ; 

        numeros.text = ""+SumaRestar.resultado ;

        SumaRestar.resultado+= 1f * Time.deltaTime * velocidad;

        SumaRestar.resultado = Math.Round(SumaRestar.resultado,2);

        //double intensidadCo2 = Math.Round(intensidadCo,2);

        intensidadC.text = ""+SumaRestar.intensidad;

        //if( SumaRestar.mensaje.Equals("Conecto") ){

            SumaRestar.intensidad=(SumaRestar.resultado/SumaRestar.resistencia);

            SumaRestar.intensidad= Math.Round(SumaRestar.intensidad,2);
        
        //}else{

            SumaRestar.intensidad=0.00;

        //}

        //de aca sale el error al llamar la variable sumarestar.mensaje, es una variable statica que esta en el script SumaRestar
        

        //SumaRestar.intensidad = Math.Round(SumaRestar.intensidad,2);

        }

    } 


    

}
