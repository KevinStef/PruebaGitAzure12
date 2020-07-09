using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosicionResistenciaL4P3 : MonoBehaviour
{

    public Image imagen;

    public bool conectado;

    public List<int> numeroGrupos;
    void Start()
    {
        this.conectado = false;
        numeroGrupos = new List<int>();
    }

    
    void Update()
    {
        if (numeroGrupos.Count==2 && !conectado)
        {
            this.conectado = true;

            imagen.color = Color.green;
        }
        else if(numeroGrupos.Count == 0 && conectado)
        {
            this.conectado = false;

            imagen.color = Color.red;
        }
    }

}
