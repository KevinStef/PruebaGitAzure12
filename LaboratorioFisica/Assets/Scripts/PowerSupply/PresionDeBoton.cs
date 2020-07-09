using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PresionDeBoton : MonoBehaviour
{
    private Renderer rend;
    private Color colorRojo;
    private Color colorVerde;
    private bool presionado;
    void Start()
    {

        this.rend = GetComponent<Renderer>();
        this.colorRojo = Color.red;
        this.colorVerde = Color.green;
        this.presionado = true;

    }
    void Update()
    {

    }

    private void OnMouseDown()
    {

        if (!presionado)
        {
            rend.material.color = this.colorRojo;
            presionado = true;
        }else if (presionado)
        {
            rend.material.color = this.colorVerde;
            presionado = false;
        }

    }

    public bool estaPresionado()
    {
        return this.presionado;
    }
}
