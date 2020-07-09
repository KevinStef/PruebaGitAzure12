using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionFR100 : MonoBehaviour
{
    //Dejemoslo por ahora. El problema no era el script, sino como estaban configuradas las animaciones.
    public Animator agujaAnimatorController;
    private string[] lineas;
    private static int posicion;

    void Start()
    {
        lineas = new string[] {"linea1", "linea2", "linea3", "linea4", "linea5", "linea6", "linea7", "linea8", "linea9", "linea10", "linea11", "linea12" };
        posicion = 0;
        agujaAnimatorController = GetComponent<Animator>();
        agujaAnimatorController.SetBool(lineas[posicion], true);
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
                agujaAnimatorController.SetBool(lineas[posicion], false);
            
            if (posicion>0)
            {
                posicion--;

            }

            agujaAnimatorController.SetBool(lineas[posicion], false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
                agujaAnimatorController.SetBool(lineas[posicion], true);
            
            if (posicion<11)
            {
                posicion++;
            }

            agujaAnimatorController.SetBool(lineas[posicion], true);
        }

    }

    public static int getPosicionEstado()
    {
        return posicion;
    }
}
