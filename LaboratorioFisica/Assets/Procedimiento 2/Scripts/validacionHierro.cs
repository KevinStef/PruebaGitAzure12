using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class validacionHierro : MonoBehaviour
{
    public TextMesh texto3;
    //private double longitud=0.3;

    private double longitud;
    private double restividad=0.0000001;
    private string simbolo;

    private double areaT;
    private double resisT;
    public Text logh;
    public string longih;
    public bool estado;
    public GameObject inputfield;
    public GameObject ingresar;
    
void Start(){
 //restividad=49/100000000;

 longih=""+logh.text;
 
areaT=4.90625f;

areaT=areaT/100000000;
areaT=Math.Round(areaT,10);
CambioNegro.cantidad=0;


}
    
        
    void Update(){
        if(CambioNegro.cantidad!=6){
            texto3.text="0.00";
            
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
 public void IngresarLongHierro(){
     longih=""+logh.text;
     longitud=double.Parse(longih);
     longitud=longitud*0.01;
     Debug.Log(longitud);
     calcularResitividad();
    CondicionHierro();
     
 }

 public void CondicionHierro(){
      if(CambioNegro.cantidad==6 && estado==true){
            Debug.Log(areaT);
            Debug.Log(resisT);
            texto3.text=""+resisT+"x10^-17"+"Ω";
        }else{
          texto3.text="0.00";
      }
 }
   
}
