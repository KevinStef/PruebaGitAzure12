using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosicionResistenciaL4P1 : MonoBehaviour
{
    public Image imagen;

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
        if (contactos == 2 && numeroGrupos.Count==2 && !conectado)
        {
            this.conectado = true;
            CircuitoTerminadoL4P1.numeroConexiones++;

            imagen.color = Color.green;
        }
        else if( contactos == 0 && numeroGrupos.Count == 0 && conectado)
        {
            CircuitoTerminadoL4P1.numeroConexiones--;
            this.conectado = false;

            imagen.color = Color.red;
        }
    }

}
