using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragL4P3 : MonoBehaviour
{
    //variables publicas
    public float distance;
    public GameObject objetoCogible;

    //variables privadas
    Sequence mySequence;
    private float posicionInicialY;

    private void Start()
    {
        mySequence = DOTween.Sequence();

        //se modifican las caracteristicas del rigidbody
        this.objetoCogible.GetComponent<Rigidbody>().useGravity = false;
        this.objetoCogible.GetComponent<Rigidbody>().isKinematic = true;

        //se obtiene la posicion inicial en el eje y de la resistencia
        this.posicionInicialY = objetoCogible.transform.position.y;
    }
    private void Update()
    {
        acercarAlejarObjetoDeCamara();
    }

    /*
     En este método se aleja y se acerca la resistencia a la hora de arrastrarlo. 
    El acercamiento y alejamiento se realiza con la rueda del mouse
     */
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
     Este metodo permite que el puntero pueda arrastrar el cubo
     */
    private void OnMouseDrag()
    {

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        objetoCogible.transform.position = objectPos;
        
        //Rota al objeto con flecha izquierda y derecha
        float rotY = Input.GetAxis("Horizontal") * Time.deltaTime;
        objetoCogible.transform.RotateAround(Vector3.up, rotY);

    }

    /*
     Este metodo permite que objeto caiga al suelo una vez dejado de hacerle clic
     */
    private void OnMouseUp()
    {
        mySequence.Append(objetoCogible.transform.DOMoveY(posicionInicialY,0.2F));
    }
}