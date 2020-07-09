using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electrodo : MonoBehaviour {
    public GameObject[] varillasInferiores;
    public ModuleManager mdManager;
    public int chargeType = 0;
    public bool isCharged;
    public bool isTouched;
    public bool inducted;
    public bool isOnTrigger;
    public Vector3 magnetism;
    public GameObject[] ElectrodoTexts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    //METYODOS TRANSFOR PAR ELECTRODO ERECTANGULARES 
    #region Magnetism Reactions Methods

    public void positiveMagnetism()
    {
        varillasInferiores[0].transform.Rotate(magnetism * -1.0f);
        varillasInferiores[1].transform.Rotate(magnetism * 1.0f);
    }

    public void negativeMagnetism()
    {
        varillasInferiores[0].transform.Rotate(magnetism * 1.0f);
        varillasInferiores[1].transform.Rotate(magnetism * -1.0f);
    }

    private void removeLoad()
    {
        varillasInferiores[0].transform.localRotation = new Quaternion(0f, 0f, -0.7071068f, 0.7071068f);
        varillasInferiores[1].transform.localRotation = new Quaternion(0f, 0f, -0.7071068f, 0.7071068f);
    }
    #endregion

    //CARAG Y DESCAGA POR COLISION O ACERCAMINETO DE MANO O VARILLA + MSJ
    #region Collisions Detections
    //Touched
    private void OnCollisionEnter(Collision collision)
    {
        //SE OBTIENE POSICION Y OBJETO COPIADO DE OBJERTO COLISIONADOR
        Transform t = collision.collider.transform;
        //SEGUN TAG SE REALIZARA BOOL , CAMBIAR MSJ,SE MODIFICARA TRANSFORM DE ELECRTROSOD RE CTANGULARES 
        switch (t.tag)
        {
            case "Mano":
                isTouched = true;
                mdManager.cambiarMensaje("Mediante el contacto físico, se ha descargado el electroscopio \npuesto que nuestro cuerpo transmite la carga que se almacenaba directo a tierra.");
                isCharged = false;
                removeLoad();
                resetTexts();
                
                break;
            case "Varilla":
                if(t.GetComponent<Varilla>().isCharged==true)
                {
                    mdManager.cambiarMensaje("Como se aprecia, las varillas inferiores ya no vuelven a juntarse, \ndebido a que los electrones de la varilla ahora se encuentran en el electrodo exterior, \ny aquellos que bajaron tuvieron que mantenerse en las varillas inferiores.");
                    //LLAMAR METODO DE VARILLA DESCARGAR
                    t.GetComponent<Varilla>().discharge();
                    isCharged = true;
                    chargeType = t.GetComponent<Varilla>().chargeType;
                }
                break;
        }
    }



    private void OnCollisionExit(Collision collision)
    {
        Transform t = collision.collider.transform;
        switch (t.tag)
        {
            case "Mano":
                isTouched = false;
                break;
        }
    }


    //CUANDO LA VARILLA ESRE CERCA PODRA ESTARR CARGADA  NO NO , DE ESTAR CARGADA SE VERA SI SE TOCO AL ELECTRODO LA MANO  Y YA NO ESTA 
    //O SI SE SIGE TOCADO AL ELECTRO, Y SE MOSTARRAN MSJ Y SEGUN CARGA DE VARLLA SE LLAMDAS POR CAMBIOS EN TRANSFORM DE ELECTRODOS RECTANGULAARES
    //Near
    private void OnTriggerEnter(Collider other)
    {
        Transform t = other.transform;
        if (t.tag=="Varilla")
        {
            
            if (t.GetComponent<Varilla>().isCharged == true)
            {
                isOnTrigger = true;
                if (isTouched == false)
                {
                    mdManager.cambiarMensaje("Podemos notar que las varillas inferiores se separan intentando \nalejarse de la varilla que acercamos, esto se debe \na que los electrones huyen de la carga negativa presente en nuestra varilla");
                    if (isCharged==false)
                    {
                        writeTexts(t.GetComponent<Varilla>().chargeType);
                        positiveMagnetism();
                    }
                    else
                    {
                        if (chargeType != t.GetComponent<Varilla>().chargeType)
                        {
                            mdManager.cambiarMensaje("Se observa que las varillas se unen, esto se debe a que la varilla contiene una carga \nopuesta a la de estas. Lo cual las atrae.");
                            negativeMagnetism();
                            
                        }
                        else
                        {
                            mdManager.cambiarMensaje("Se observa que las varillas se unen, esto se debe a que la varilla contiene una carga \nopuesta a la de estas. Lo cual las atrae.");
                            positiveMagnetism();
                        }
                    }
                }
                else
                {
                    mdManager.cambiarMensaje("Al estar conectadas a tierra mediante el contacto físico, \nla carga es transferida y no se mueven las varillas inferiores.");
                    isCharged = true;
                    inducted = true;
                    chargeType = t.GetComponent<Varilla>().chargeType;
                }
            }
            else if (isCharged == false && t.GetComponent<Varilla>().isCharged == false)
            {

                mdManager.cambiarMensaje("Podemos observar que no ocurre nada debido a que ambos objetos \nse encuentran descargados (en estado neutral).");
            }
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        Transform t = other.transform;
        if (t.tag == "Varilla")
        {
            //DE ESATR CARGADA LA VARILLA ANTES Y EL ELECTRODO NO ESTA CARGADO ENTCS SE MOVERA EL TRANSFORM DE LOS ELECTRODOS, 
            // LO TOCO LA MANO ANTES PERO YA NO , ENTCS SE MOVERA EL TRNSFORM DE LOS ELECTRODOS
            // PERO SI EL ELECTRODO ESTA CARGADO Y SI LAVARILLA ESTABA CAARGADA ENTCS SEGUN LA CARGA 
            //SE MOVERAN LOS TRABNFROM DE LOS ELECTRDOS

            isOnTrigger = false;
            if (t.GetComponent<Varilla>().isCharged == true)
            {
                if (isCharged == false)
                {
                    removeLoad();
                    resetTexts();
                }
                else if (inducted==true)
                {
                    inducted = false;
                    positiveMagnetism();

                }
                else
                {
                    if (t.GetComponent<Varilla>().chargeType == chargeType)
                    {
                        negativeMagnetism();
                        resetTexts();
                    }
                    else
                    {
                        positiveMagnetism();
                    }
                }
            }
        }
    }
    #endregion

    #region Texts
    private void resetTexts()
    {
        foreach (GameObject gObj in ElectrodoTexts)
        {
            gObj.GetComponent<TextMesh>().text = "";
        }
    }

    private void writeTexts(int cT)
    {
        if(cT == 1)
        {
            ElectrodoTexts[0].GetComponent<TextMesh>().text = "-";
            ElectrodoTexts[0].GetComponent<TextMesh>().color = Color.blue;
            ElectrodoTexts[1].GetComponent<TextMesh>().text = "+";
            ElectrodoTexts[1].GetComponent<TextMesh>().color = Color.red;
            ElectrodoTexts[2].GetComponent<TextMesh>().text = "+";
            ElectrodoTexts[2].GetComponent<TextMesh>().color = Color.red;
        }
        else if (cT == -1)
        {
            ElectrodoTexts[0].GetComponent<TextMesh>().text = "+";
            ElectrodoTexts[0].GetComponent<TextMesh>().color = Color.red;
            ElectrodoTexts[1].GetComponent<TextMesh>().text = "-";
            ElectrodoTexts[1].GetComponent<TextMesh>().color = Color.blue;
            ElectrodoTexts[2].GetComponent<TextMesh>().text = "-";
            ElectrodoTexts[2].GetComponent<TextMesh>().color = Color.blue;

        }

    }

    #endregion
}
