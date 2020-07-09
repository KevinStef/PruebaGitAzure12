using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesGlobales : MonoBehaviour
{
    //Es el numero final que nos aparecera en el multimetro
    public static float multimetro;

    //Nos ayudara saber si el circuito esta conectado o no
    public static int NumeroCondicion;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(NumeroCondicion);
    }

}
