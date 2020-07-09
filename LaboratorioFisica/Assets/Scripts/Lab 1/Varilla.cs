using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varilla : MonoBehaviour {
    public Collider campo;
    public ModuleManager mdManager;
    public int step;
    public float charge;
    public bool isMoving;
    public bool isCharged;
    public int chargeType;
    public Vector3 lastPosition;
    public GameObject textoCarga;

    private void Start()
    {
        charge = 0f;
        isCharged = false;
        isMoving = false;
    }
    private void Update()
    {
        //POR FRAME Y POPR POSICION REVISARA SI SE MUEVE O NO
        if(transform.position == lastPosition)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
        lastPosition = transform.position;
    }

    //MIENTARS HALLA UN OBJETO-PERIODICO CERCA Y LAVARILLA SE ESTA MOVIENOD
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.name == "Periodico")
        {
            if(isMoving == true)
            {
                //CHARGE ALMACENARA LOS SEGUNDOS SI ALCANZA 5 SEGUNDOS SE CARGARA
                charge += Time.deltaTime;
                if (charge >= 1.25)
                {
                    charge = 5f;
                    isCharged = true;
                    mdManager.cambiarMensaje("Has cargado la varilla mediante fricción.");

                    switch (chargeType){
                        case 1:
                            textoCarga.GetComponent<TextMesh>().text = "+";
                            textoCarga.GetComponent<TextMesh>().color = Color.red;
                            break;

                        case -1:
                            textoCarga.GetComponent<TextMesh>().text = "-";
                            textoCarga.GetComponent<TextMesh>().color = Color.blue;
                            break;
                    }
                    
                }
            }
        }
    }

    internal void discharge()
    {
        isCharged = false;
        charge = 0;
        textoCarga.GetComponent<TextMesh>().text = " ";
    }
}
