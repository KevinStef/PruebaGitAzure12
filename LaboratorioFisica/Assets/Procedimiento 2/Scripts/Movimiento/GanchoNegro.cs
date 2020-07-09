using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class GanchoNegro : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject obj;
   public Vector3 Posicionfinal;
   public Vector3 RotacionFinal;
   private Vector3 PosicionInicial;
   public  Image imagen5;
   public Image imagen6;
   Sequence mySequence;
   private bool conectado;
   void start(){
       mySequence=DOTween.Sequence();
       conectado=false;
   }
   private void OnMouseDown(){
       if(obj.CompareTag("GanchoL")){
       if(!conectado){
           mySequence.Append(obj.transform.DOLocalMove(Posicionfinal,0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(RotacionFinal,0.5f));
           CambioNegro.cantidad++;
           conectado=true;
           imagen5.color=Color.green;
           
       }else{
           mySequence.Append(obj.transform.DOLocalMove(new Vector3(-3.77f,2.2206f,-5f),0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(new Vector3(0,0,0),0.5f));
           CambioNegro.cantidad--;
           conectado=false;
           imagen5.color=Color.red;
       }
       }else if(obj.CompareTag("GanchoD")){
        if(!conectado){
           mySequence.Append(obj.transform.DOLocalMove(Posicionfinal,0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(RotacionFinal,0.5f));
           CambioNegro.cantidad++;
           conectado=true;
           imagen6.color=Color.green;
           
           
       }else{
           mySequence.Append(obj.transform.DOLocalMove(new Vector3(-3.77f,2.2206f,-4.781f),0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(new Vector3(0,0,0),0.5f));
           CambioNegro.cantidad--;
           conectado=false;
           imagen6.color=Color.red;
     }   
       }
   }
}
