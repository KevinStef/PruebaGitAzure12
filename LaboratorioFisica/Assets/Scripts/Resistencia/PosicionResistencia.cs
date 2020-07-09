using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionResistencia : MonoBehaviour
{

    public static int contactos;

    public bool conectado;

    public List<int> numeroGrupos;
    void Start()
    {
        contactos = 0;
        this.conectado = false;
        numeroGrupos = new List<int>();
    }

    
    void Update()
    {
        if (contactos == 2 && numeroGrupos.Count==2)
        {
            this.conectado = true;
        }
        else
        {
            this.conectado = false;
        }
    }

}
