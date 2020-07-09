using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltaT : MonoBehaviour
{
   
    public float tiempo;

    public TextMesh textoTiempo;

    private bool estado;

    void Start()
    {
        tiempo=60;
        textoTiempo.text = tiempo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(estado){

            tiempo -= Time.deltaTime;

            textoTiempo.text = tiempo.ToString();

        }
    }

    public void Empezar(){

        estado = !estado;

    }


}
