using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class CambioNegro : MonoBehaviour
{
   public static float cantidad;
   public GameObject obj;
   public Vector3 Posicionfinal;
   public Vector3 RotacionFinal;
   private Vector3 PosicionInicial;
   public Image imagen1;
   public Image imagen2;
   Sequence mySequence;
   private bool conectado;
   void start(){
       mySequence=DOTween.Sequence();
       conectado=false;
   }
   void Update(){
       Debug.Log(cantidad);
   }
   private void OnMouseDown(){
       if(obj.CompareTag("Negro1")){
       if(!conectado){
           mySequence.Append(obj.transform.DOLocalMove(Posicionfinal,0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(RotacionFinal,0.5f));
           cantidad++;
           conectado=true;
           imagen1.color=Color.green;
           
       }else{
           mySequence.Append(obj.transform.DOLocalMove(new Vector3(-0.0182f,0.0251f,0.0011f),0.5f));
           mySequence.Append(obj.transform.DOLocalRotate(new Vector3(369.19f,-271.52f,184.608f),0.5f));
           cantidad--;
           conectado=false;
           imagen1.color=Color.red;
       }
       }else if(obj.CompareTag("Negro2")){
        if(!conectado){
           mySequence.Append(obj.transform.DOLocalMove(Posicionfinal,0.5f));
           cantidad++;
           conectado=true;
           imagen2.color=Color.green;
           
       }else{
           mySequence.Append(obj.transform.DOLocalMove(new Vector3(0.0877f,0.0216f,0),0.5f));
           cantidad--;
           conectado=false;
           imagen2.color=Color.red;
       }   
       }
   }
}
