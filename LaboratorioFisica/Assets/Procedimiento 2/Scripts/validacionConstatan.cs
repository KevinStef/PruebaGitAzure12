using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class validacionConstatan : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMesh texto1;
    private double longitud=0;
        
    private double restividad=0.000000049;
    private string simbolo;

    private double areaT;
    private double resisT;
    public Text longt;
    public string longs;
    public bool estado;
    public GameObject inputfield;
    public GameObject ingresar;
    
    
    
    
void Start(){
 
 longs=""+longt.text;
 

areaT=4.90625f;

areaT=areaT/100000000;
areaT=Math.Round(areaT,10);
CambioNegro.cantidad=0;

}
    
     
    void Update(){
        
        if(CambioNegro.cantidad!=6){
            texto1.text="0.00";
            
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
 public void ingresarLongitud(){
     longs=""+longt.text;
     longitud=Double.Parse(longs);
     longitud=longitud*0.01;
     Debug.Log(longitud);
     calcularResitividad();
     condicion1();
     }
  public void condicion1(){
      if(CambioNegro.cantidad==6 && estado==true){
          Debug.Log(areaT);
          Debug.Log(resisT);
          texto1.text=""+resisT+"x10^-16"+"Ω";
      }else{
          texto1.text="0.00";
      }
  } 
}
