using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton : MonoBehaviour
{

    public bool color=false;

    private Renderer colorC;

    public GameObject plus;

    public GameObject minus;

    public Button botonActivacion;

    // Start is called before the first frame update
    void Start()
    {
        colorC = GetComponent<Renderer>();
        colorC.material.SetColor("_Color",Color.red);
        color=false;
    }

    // Update is called once per frame
    void Update()
    {
        bool revisionCircuito= GestorCircuito.instance.circuitoConstruidoAlimentacion;
        if(!color && !revisionCircuito){
            color=true;
            botonActivacion.interactable=false;
            colorC.material.SetColor("_Color",Color.red);
            plus.GetComponent<sumar>().status=color;
            minus.GetComponent<restar>().status=color;
            GestorCircuito.instance.voltajeListo = false;
            
        }
    }

    void OnMouseDown(){

        CambiarColor();

    }

    private void CambiarColor(){
        float numeroCapacitor= AdminCapacitores.instance.idCapacitor;

        if(GestorCircuito.instance.circuitoConstruidoAlimentacion && numeroCapacitor==3)
        {
            if(color){
                botonActivacion.interactable=true;
                colorC.material.SetColor("_Color",Color.green);
                plus.GetComponent<sumar>().status=color;
                minus.GetComponent<restar>().status=color;
                color=false;
            //}else if(!color){
            }else{
                botonActivacion.interactable=false;
                colorC.material.SetColor("_Color",Color.red);
                plus.GetComponent<sumar>().status=color;
                minus.GetComponent<restar>().status=color;
                GestorCircuito.instance.voltajeListo = false;
                color=true;

        }
        }
       

    }

}
