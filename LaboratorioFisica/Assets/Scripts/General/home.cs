using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour {

    public ModuleManager mdManager;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        mdManager.cambiarMensaje("la weea entroo");
        mdManager.backHome("Scene");



    }
    //void TaskOnClick()
    //{
    //    mdManager.cambiarMensaje("aun no procesa goto");
    //    mdManager.goToScene(0);
    //    mdManager.cambiarMensaje("ya pasooo");
    //}
}
