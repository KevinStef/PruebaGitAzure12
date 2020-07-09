using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class validacionNicron : MonoBehaviour
{
    public TextMesh texto2;
    private double longitud;
        
    private double restividad=0.0000001;
    private string simbolo;

    private double areaT;
    private double resisT;
    public Text lonf;
    public string lontf;
    public bool estado;
    public GameObject inputfield;
    public GameObject ingresar;
    
void Start(){
 
 
 lontf=""+lonf.text;
areaT=4.90625f;

areaT=areaT/100000000;
areaT=Math.Round(areaT,10);
CambioNegro.cantidad=0;


}
    
 
    void Update(){
      if(CambioNegro.cantidad!=6){
            texto2.text="0.00";
            
        }
        estado=MovimientoPerillaMultimetro.obteneropcion5();
         if(CambioNegro.cantidad==6){
            inputfield.SetActive(true);
            ingresar.SetActive(true);
        }
        
    }
    
 public void calcularResitividad(){
     resisT=restividad*(longitud/areaT);
     
     resisT=Math.Round(resisT,3);
     resisT=resisT*10;

 }
 public void IngresarLongNicron(){
    lontf=""+lonf.text;
    longitud=double.Parse(lontf);
    longitud=longitud*0.01;
     Debug.Log(longitud);
     calcularResitividad();
    CondicionNicron();
     
 }
 public void CondicionNicron(){
     if(CambioNegro.cantidad==6 && estado==true){
          Debug.Log(areaT);
          Debug.Log(resisT);
          texto2.text=""+resisT+"x10^-6"+"Ω";
      }else{
          texto2.text="0.00";
      }
 }
 
}
