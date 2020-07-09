using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectarCircuitoTerminado : MonoBehaviour
{

    bool circuitoCompleto;

    public Animator agujaAnimatorController;

    bool conexionLista;

    public float conexionesMulti {get;set;}

    public TextMeshProUGUI avisoEstado;
    void Start()
    {
        circuitoCompleto = false;
        conexionLista = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Revisa si la perilla esta en posicion y si todos los cables estan conectados
        int opcionPerilla = FuncionFR100.getPosicionEstado();

        
        bool conexionPreparada = AdminCapacitores.instance.circuitoCompleto;

        if(conexionesMulti>1){

        }
        //Una vez configurado todo, ahora si la perilla se mueve.
        if(opcionPerilla == 10 && conexionesMulti>1){

            if(conexionPreparada && !circuitoCompleto)
            {

               circuitoCompleto=true;
               ejecutarEstado();
               


            }else if (!conexionPreparada && circuitoCompleto)
            {   
                circuitoCompleto=false;
                ejecutarEstado();
                avisoEstado.text="";

            }

        //Si se cambia de modo
        }else{

            if(circuitoCompleto){
                circuitoCompleto=false;
                ejecutarEstado();
                avisoEstado.text="";
            }
                

            
        }

        
    }

    private void ejecutarEstado()
    {
        
        if(circuitoCompleto)
        {
            switch(AdminCapacitores.instance.idCapacitor)
                {
                case 1: 
                    agujaAnimatorController.SetBool("abierto", true);
                    //Debug.Log("Abierto");
                    avisoEstado.text="Abierto";
                    break;

                case 2:
                    agujaAnimatorController.SetBool("fuga", true);
                    //Debug.Log("Con Fuga");
                    avisoEstado.text="Con fuga";
                    break;

                case 3:
                    agujaAnimatorController.SetBool("operativo", true);
                    //Debug.Log("Operativo");
                    avisoEstado.text="Operativo";
                    break;

                case 4:
                    agujaAnimatorController.SetBool("cortocircuitado", true);
                    //Debug.Log("CortoCircuitado");
                    avisoEstado.text="Cortocircuitado";
                    break;

                default:

                    agujaAnimatorController.SetBool("abierto", false);
                    agujaAnimatorController.SetBool("fuga", false);
                    agujaAnimatorController.SetBool("operativo", false);
                    agujaAnimatorController.SetBool("cortocircuitado", false);
                    //Debug.Log("No se detecto un capacitor. Revisa.");
                    break;

            }

        }else{
            
            switch(AdminCapacitores.instance.idCapacitor)
            {
                case 1: 
                    agujaAnimatorController.SetBool("abierto", false);
                    //Debug.Log("Desconectaste el abierto");
                    break;

                case 2:
                    agujaAnimatorController.SetBool("fuga", false);
                    //Debug.Log("Desconectaste el fugado");
                    break;

                case 3:
                    agujaAnimatorController.SetBool("operativo", false);
                    //Debug.Log("Desconectaste el operativo");
                    break;

                case 4:
                    agujaAnimatorController.SetBool("cortocircuitado", false);
                    //Debug.Log("Desconectaste el cortocircuitado");
                    break;
                default: 
                    agujaAnimatorController.SetBool("abierto", false);
                    agujaAnimatorController.SetBool("fuga", false);
                    agujaAnimatorController.SetBool("operativo", false);
                    agujaAnimatorController.SetBool("cortocircuitado", false);
                    //Debug.Log("No se detecto un capacitor. Revisa.");

                    break;
            }
        }
        
    }
    


}
