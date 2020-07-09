using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragCableRojoL4P1 : MonoBehaviour
{
    public float distance;
    public GameObject objetoCogible;
    public bool tocarSuelo;

    Sequence mySequence;
    private float posicionInicialY;

    private void Start()
    {
        mySequence = DOTween.Sequence();
        this.objetoCogible.GetComponent<Rigidbody>().useGravity = false;
        this.objetoCogible.GetComponent<Rigidbody>().isKinematic = true;
        this.posicionInicialY = objetoCogible.transform.position.y;

        this.tocarSuelo = true;
    }
    private void Update()
    {
        acercarAlejarObjetoDeCamara();
    }

    private void acercarAlejarObjetoDeCamara()
    {
        float distanciaCameraCubo = Input.mouseScrollDelta.y;
        if (distanciaCameraCubo > 0)
        {
            distance += 0.01F;
        }
        else if (distanciaCameraCubo < 0)
        {
            distance -= 0.01F;
        }
    }

    /*
     Este método permite que el puntero pueda arrastrar el cubo
     */
    private void OnMouseDrag()
    {

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        objetoCogible.transform.position = objectPos;

    }

    /*
     Este metodo permite que olbjeto caiga al suelo una vez dejado de hacerle clic
     */
    private void OnMouseUp()
    {
        if (tocarSuelo)
        {
            mySequence.Append(objetoCogible.transform.DOMoveY(posicionInicialY, 0.2F));
        }
    }
}
