using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CambioRojo : MonoBehaviour
{
  public GameObject obj;
  
   public Vector3 Posicionfinal;
   public Vector3 RotacionFinal;
   private Vector3 PosicionInicial;
   public Image imagen3;
   public Image imagen4;
   Sequence mySequence;
   private bool conectado;
   void start(){
       mySequence=DOTween.Sequence();
       conectado=false;
   }
   private void OnMouseDown(){
       if(obj.CompareTag("Rojo1")){
       if(!conectado){
           mySequence.Append(obj.transform.DOLocalMove(Posicionfinal,0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(RotacionFinal,0.5f));
           CambioNegro.cantidad++;
           conectado=true;
           imagen3.color=Color.green;
           
       }else{
           mySequence.Append(obj.transform.DOLocalMove(new Vector3(-0.033f,-0.0058f,-0.0053f),0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(new Vector3(169.35f,-91.35999f,8.17099f),0.5f));
           CambioNegro.cantidad--;
           conectado=false;
           imagen3.color=Color.red;
       }
       }else if(obj.CompareTag("Rojo2")){
        if(!conectado){
           mySequence.Append(obj.transform.DOLocalMove(Posicionfinal,0.5f));
           CambioNegro.cantidad++;
           conectado=true;
           imagen4.color=Color.green;
           
           
       }else{
           mySequence.Append(obj.transform.DOLocalMove(new Vector3(0.0877f,-0.008f,0),-0.0053f));
           CambioNegro.cantidad--;
           conectado=false;
           imagen4.color=Color.red;
       }   
       }
   }
}
