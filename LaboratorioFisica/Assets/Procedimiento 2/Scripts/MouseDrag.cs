using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public bool trapasoSuelo;
    public float distance;
    public GameObject objetoCogible;
    public Transform objtoCogiblePosition;
    public Transform suelo;
    public float distanceSueldoObjeto;
    public float delimitadorDistancia;
    public float velocidadElevarse;

    private bool estaCogido;
    private void Update()
    {

        acercarAlejarObjetoCamera();
        //Se calcula la distancia entre el suelo y el cubo
        var vectorDistancia = objtoCogiblePosition.position - suelo.position;
        //se iguala el valor del eje y de la distancia calculada
        distanceSueldoObjeto = vectorDistancia.y;

        TraspasoSuelo();
        ReposicionarObjeto();
    }

    private void acercarAlejarObjetoCamera()
    {
        float distanciaCameraCubo = Input.mouseScrollDelta.y;
        if (distanciaCameraCubo > 0)
        {
            distance += 1F;
        }
        else if (distanciaCameraCubo < 0)
        {
            distance -= 1F;
        }
    }

    /*
    Este método validará si se traspasó el suelo o no, en base al delimitador 
    */
    private void TraspasoSuelo()
    {
        if (distanceSueldoObjeto > delimitadorDistancia)
        {
            trapasoSuelo = false;
        }
        else
        {
            trapasoSuelo = true;
        }
    }
    /*
     Este método reposiciona al objeto encima del suelo, si es que el objeto llega a traspasar el suelo
     */
    private void ReposicionarObjeto()
    {
        if (trapasoSuelo)
        {
            objetoCogible.GetComponent<Rigidbody>().useGravity = false;
            objetoCogible.GetComponent<Rigidbody>().isKinematic = true;
            objtoCogiblePosition.Translate(Vector3.up * Time.deltaTime * velocidadElevarse, Space.World);
            objetoCogible.GetComponent<Rigidbody>().useGravity = true;
            objetoCogible.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    /*
     Este método permite que el puntero pueda arrastrar el cubo
     */
    private void OnMouseDrag()
    {
        objetoCogible.GetComponent<Rigidbody>().useGravity = false;
        objetoCogible.GetComponent<Rigidbody>().isKinematic = true;

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        objetoCogible.transform.position = objectPos;



    }

    private void OnMouseUp()
    {
        objetoCogible.GetComponent<Rigidbody>().useGravity = true;
        objetoCogible.GetComponent<Rigidbody>().isKinematic = false;
    }
}