using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorMovimiento : MonoBehaviour
{
    public static GestorMovimiento instance = null;
    public float componentesCircuitosConectado { get; set; }
    public bool circuitoConstruidoAlimentacion { get; set; }
    public bool voltajeListo { get; set; }
    public bool positivoOcupado { get; set; }
    public float conexionesDirectasCapacitor { get; set; }
    public bool conectadoAlimentador { get; set; }
    public bool deteccionCapacitor { get; set; }
 
    public int resistencia470;
    public GameObject colorR470;
    public Text nomResis470;
    public int resistencia1;
    public GameObject colorR1;
    public Text nomResis1;
    public int resistencia10;
    public GameObject colorR10;
    public Text nomResis10;
    public int resistencia560;
    public GameObject colorR560;
    public Text nomResis560;
    public int conexionDirecta1;
    public GameObject colorConexionDirecta1;
    public Text nomConexionDirecta1;
    public int conexionIndirecta1;
    public GameObject colorConexionIndirecta1;
    public Text nomConexionIndirecta1;
    public int conexionDirecta2;
    public GameObject colorConexionDirecta2;
    public Text nomConexionDirecta2;
    public int conexionIndirecta2;
    public GameObject colorConexionIndirecta2;
    public Text nomConexionIndirecta2;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        componentesCircuitosConectado = 0;
    }
    // Update is called once per frame
    void Update()
    {
        conexionPanelR1();
        conexionDirecta();
        conexionIndirectaM();
        conexionDirecta2T();
        conexionIndirectaM2();
    }
    public void ConexionCapacitor()
    {
        conexionesDirectasCapacitor++;
        Debug.Log("Conexiones : " + conexionesDirectasCapacitor);
       

        if (conexionesDirectasCapacitor > 6)
        {
            circuitoConstruidoAlimentacion = true;
            Debug.Log("Cantidad " + conexionesDirectasCapacitor);
        }
    }
    public void DesconexionCapacitor()
    {
        conexionesDirectasCapacitor--;
        if (conexionesDirectasCapacitor <= 6)
        {
            circuitoConstruidoAlimentacion = true;
            voltajeListo = false;
        }
        if (conexionesDirectasCapacitor < 1)
        {
            conectadoAlimentador = false;
        }
    }
    public void ConstruccionCircuito()
    {
        componentesCircuitosConectado++;
        Debug.Log(componentesCircuitosConectado);
    }
    public void DesconexionCircuito()
    {
        Debug.Log(componentesCircuitosConectado);
        componentesCircuitosConectado--;
      
    }

    public void conexionPanelR1(){

        if(resistencia1 == 2){

            colorR1.GetComponent<Image>().color = Color.green; 

        }else{

            colorR1.GetComponent<Image>().color = Color.red; 

        }

    }

    public void sumarResistencia470(){

        colorR470.GetComponent<Image>().color = Color.green ;
        nomResis470.text = ""+1 ;

    }

    public void restarResistencia470(){

        colorR470.GetComponent<Image>().color = Color.red; 
        nomResis470.text = ""+0 ;

    }

    public void sumarResistencia1(){

        resistencia1++;
        nomResis1.text = ""+ resistencia1;

    }

    public void restarResistencia1(){

        resistencia1--;
        nomResis1.text = ""+ resistencia1;

    }

    public void sumarResistencia10(){

        colorR10.GetComponent<Image>().color = Color.green ;
        nomResis10.text = ""+1 ;

    }

    public void restarResistencia10(){

        colorR10.GetComponent<Image>().color = Color.red; 
        nomResis10.text = ""+0 ;

    }

    public void sumarResistencia560(){

        colorR560.GetComponent<Image>().color = Color.green ;
        nomResis560.text = ""+1 ;

    }

    public void restarResistencia560(){

        colorR560.GetComponent<Image>().color = Color.red; 
        nomResis560.text = ""+0 ;

    }

    public void conexionDirecta(){

        if(conexionDirecta1 == 9){

            colorConexionDirecta1.GetComponent<Image>().color = Color.green; 

        }else{

            colorConexionDirecta1.GetComponent<Image>().color = Color.red; 

        }

    }

    public void conexionDirecta2T(){

        if(conexionDirecta1 == 9 && MovimientoPerillaMultimetro.indiceMultimetro == 4){

            colorConexionDirecta2.GetComponent<Image>().color = Color.green; 

        }else{

            colorConexionDirecta2.GetComponent<Image>().color = Color.red; 

        }

    }

    public void sumarConexionDirecta1(){

        conexionDirecta1++;

    }

    public void restarConexionDirecta1(){

        conexionDirecta1--;

    }

    public void conexionIndirectaM(){

        if(conexionIndirecta1 == 11){

            colorConexionIndirecta1.GetComponent<Image>().color = Color.green; 

        }else{

            colorConexionIndirecta1.GetComponent<Image>().color = Color.red; 

        }

    }

    public void conexionIndirectaM2(){

        if(conexionIndirecta1 == 11 && MovimientoPerillaMultimetro.indiceMultimetro == 6){

            colorConexionIndirecta2.GetComponent<Image>().color = Color.green; 

        }else{

            colorConexionIndirecta2.GetComponent<Image>().color = Color.red; 

        }

    }

    public void sumarConexionIndirecta1(){

        conexionIndirecta1++;

    }

    public void restarConexionIndirecta1(){

        conexionIndirecta1--;

    }

}
