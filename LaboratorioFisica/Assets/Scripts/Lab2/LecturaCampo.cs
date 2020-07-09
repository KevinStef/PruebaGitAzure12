using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LecturaCampo : MonoBehaviour {
    //Se puede simplificar gracias a la implementacion de Lean Touch.

    public GameObject Lector;
    public GameObject[] ElectrodosP;
    public GameObject[] ElectrodosC;
    public char Electrodos;
    public GameObject TextoMM;
    public double voltaje;
    public double distanciaE;
    public double distanciaL;
    public double valorleido;
    public GameObject ElectrodoObj;

    private GameObject getTarget;

    private double p = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            //SI CLICKEAS EN LOS ELECTRODOS, LOS ELECTRODOS P O C SE ACTIVARAN 
            RaycastHit hitInfo;
            getTarget = ReturnClickedObject(out hitInfo);

            if (getTarget != null)
            {
                if (getTarget.name == "Electrodos")
                {
                    if(ElectrodosP!=null || ElectrodosC!=null){
                        switch (Electrodos)
                            {
                        case 'C':
                            Electrodos = 'P';
                            ElectrodosC[0].SetActive(false);
                            ElectrodosC[1].SetActive(false);
                            ElectrodosP[0].SetActive(true);
                            ElectrodosP[1].SetActive(true);
                            break;

                        case 'P':
                            Electrodos = 'C';
                            ElectrodosC[0].SetActive(true);
                            ElectrodosC[1].SetActive(true);
                            ElectrodosP[0].SetActive(false);
                            ElectrodosP[1].SetActive(false);
                            break;
                        }

                    }
                   
                }
            }
        }
        if (Electrodos == 'C') //es de lso cilindross
        {
            //si la punta esta a la izquierda de del electrodo dos en cordenadas x
            if (Lector.transform.position.x <= ElectrodosC[2].transform.position.x + 0.0001)
            {
                //COMO SE CALULA EN CASO DE QUE SEAN EL EL CTRODO CIRCULAR

                distanciaE = ElectrodosC[1].transform.position.x - ElectrodosC[2].transform.position.x;

                //DISTANCIA ENTRE ELECTRODOS
                //PITAGORAS CON DIFERENCIALES (distancia entre lectro y electrodo)=dD y distanciaL
                //el error de las curva esta en que solo se estata considerando el ele ctrod 1

                var dX = Math.Abs(ElectrodosC[0].transform.position.x - Lector.transform.position.x); //numero entero
                var dZ = Math.Abs(Lector.transform.position.z - ElectrodosC[0].transform.position.z);
                var dD = Mathf.Sqrt(Mathf.Pow(dX, 2) + Mathf.Pow(dZ, 2));
                distanciaL = dD;

                valorleido = voltaje * (distanciaL / distanciaE);
                valorleido = voltaje - valorleido;

            } else{


                //COMO SE CALULA EN CASO DE QUE SEAN EL EL CTRODO CIRCULAR

                distanciaE = ElectrodosC[1].transform.position.x - ElectrodosC[2].transform.position.x;

                //DISTANCIA ENTRE ELECTRODOS
                //PITAGORAS CON DIFERENCIALES (distancia entre lectro y electrodo)=dD y distanciaL
                //el error de las curva esta en que solo se estata considerando el ele ctrod 1

                var dX = Math.Abs(ElectrodosC[1].transform.position.x - Lector.transform.position.x); //numero entero
                var dZ = Math.Abs(Lector.transform.position.z - ElectrodosC[1].transform.position.z);
                var dD = Mathf.Sqrt(Mathf.Pow(dX, 2) + Mathf.Pow(dZ, 2));
                distanciaL = dD;

                valorleido = voltaje * (distanciaL / distanciaE);
                valorleido = voltaje - valorleido;
            }

                //valorleido = voltaje * (distanciaL / distanciaE);





                ////--------------------------------------------------

                //valorleido = voltaje - valorleido;

                valorleido = Math.Round(valorleido, 2);
                if (valorleido <= 0) { valorleido = 0; } // Probar si funciona
               
                valorleido = voltaje - valorleido;
                valorleido = Math.Round(valorleido, 2);
                if (valorleido <= 0) { valorleido = 0; }
              
                valorleido = valorleido / 2;
            valorleido = Math.Round(valorleido, 2);
            if (!(Lector.transform.position.x <= ElectrodosC[2].transform.position.x + 0.0001))
            {
                valorleido = voltaje - valorleido;
            }
            TextoMM.GetComponent<TextMesh>().text = valorleido + "";

            
            //si la punta esta a la izquierda de del electrodo dos en cordenadas x
        



        }
        
        if (Electrodos == 'P')
        {
            if(ElectrodosP.Length>=0){
                 //distanciaE = ElectrodosP[1].transform.position.x - ElectrodosP[0].transform.position.x;
                distanciaE = ElectrodosP[1].transform.position.x - ElectrodosP[0].transform.position.x;
                distanciaL = Lector.transform.position.x - ElectrodosP[0].transform.position.x;
                valorleido = voltaje * (distanciaL / distanciaE);

                valorleido = Math.Round(valorleido, 2);
                if (valorleido < 0) { valorleido = 0; }
                else if (valorleido >= voltaje) { valorleido = voltaje; }
                valorleido = Math.Round(valorleido, 2);
                TextoMM.GetComponent<TextMesh>().text = valorleido + "";
            }
           
        }

    }

    internal void setVoltage(int v)
    {
       
            //SETEAR EL VOLTAJE CON V ESTO LO PUEDES USAR PARA ESCRIBIR EL VOLTAJE CON V
            voltaje = v;
    }

    internal void increaseVoltaje()
    {
        if (voltaje < 220)
        {

            voltaje++;
        }
    }

    internal void reduceVoltage()
    {
        //SOLO SI EL VOLTAJE ES POSITI VS SE VA A DISMINUIR
        if (voltaje > 0)
        {
            voltaje--;
        }
    }



    internal double getVoltage()
    {
        return voltaje;
    }

    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}
