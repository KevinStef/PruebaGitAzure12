using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModuleManager : MonoBehaviour {

    public GameObject[] cameraPositions;
    public GameObject[] canvasLabels;
    public GameObject varilla;
    public Sprite[] botonesDialogo;
    public GameObject botonDialogo;
    public GameObject mano;
    public bool Dialogos;
    public GameObject[] GUIAlterable;


    private void Start()
    {
    }

    private void Update()
    {

    }

    internal void cambiarMensaje(string newMsg)
    {
        //Resultados existe, mostrara el mensaje enviado
        if(canvasLabels[0]!=null)
        canvasLabels[0].GetComponent<Text>().text = newMsg; 
    }

    public void changeCamPos(int i)
    {
        Camera.main.transform.position = cameraPositions[i].transform.position;
        Camera.main.transform.rotation = cameraPositions[i].transform.rotation;
        switch (i)
        {
            case 0:
                //Camara Derecha
                canvasLabels[1].GetComponent<Text>().text = "Puedes frotar la varilla con el periódico arrastrandola sobre éste para cargarla.";
                break;
            case 1:
                //Camara izquierda
                canvasLabels[1].GetComponent<Text>().text = "Puedes interactuar con el electroscopio arrastrando la varilla cerca a éste o moviendo la mano con las flechas del teclado.";
                break;
        }
    }

    internal void cambiarSeleccion(string seleccion)
    {//Selección existe has hecho click en ""
        if (canvasLabels[2] != null)
            canvasLabels[2].GetComponent<Text>().text = ("Has hecho click en: " + seleccion);
    }
    internal void cambiarAyuda (string mensaje)
    {//

        canvasLabels[1].GetComponent<Text>().text = mensaje;

    }

    public void goToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void backHome(string scene)
    {
        SceneManager.LoadScene(scene);
        //Debug.Log("Home Clicked");
    }












    public Action Karma(Action input)
    {
        return input;
    }












    public void alternarDialogos()
    {
        switch (Dialogos)
        {
            case true:
                foreach(GameObject g in GUIAlterable)
                {
                    g.SetActive(false);                   
                }
                botonDialogo.GetComponent<Image>().sprite = botonesDialogo[0];
                Dialogos = false;
                break;

            case false:
                foreach (GameObject g in GUIAlterable)
                {
                    g.SetActive(true);
                }
                Dialogos = true;
                botonDialogo.GetComponent<Image>().sprite = botonesDialogo[1];
                break;
        }
    }
}
