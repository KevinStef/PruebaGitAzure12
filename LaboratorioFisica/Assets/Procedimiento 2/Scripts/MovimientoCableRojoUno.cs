using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCableRojoUno : MonoBehaviour
{
    public GameObject cableRojo;
    public GameObject cableRojoCabeza;

    Sequence mySequence;
    //Sequence mySequenceDos;
    private Vector3 posicionInicial;
    public Vector3 posicionInicialCabeza;

    private int presionado;
    void Start()
    {
        mySequence = DOTween.Sequence();
        //mySequenceDos = DOTween.Sequence();
        this.posicionInicial = cableRojo.transform.position;
        this.presionado = 0;
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (presionado == 0)
        {
            mySequence.Append(cableRojo.transform.DOMove(new Vector3(-5.866F, 2.237F, -5.821F), 4F));
            this.presionado++;
        } else if (presionado == 1)
        {
            mySequence.Append(cableRojoCabeza.transform.DOLocalMove(new Vector3(-0.1202F, 3.631366e-05F, 0.0206F), 4F));
            this.presionado++;

            
        } else if (presionado == 2)
        {
            mySequence.Append(cableRojoCabeza.transform.DOLocalMove(posicionInicialCabeza, 4F))
                .Append(cableRojo.transform.DOMove(posicionInicial, 4F));
            this.presionado = 0;

         
        }
    }
}
