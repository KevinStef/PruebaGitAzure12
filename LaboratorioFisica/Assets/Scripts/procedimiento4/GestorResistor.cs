using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GestorResistor : MonoBehaviour
{
    public static GestorResistor instance = null;
    public float componentesCircuitosConectado;
    private double R1 = 560, R2 = 560, R3 = 1, R4 = 1, R5 = 4.7;
    public double Tolerancia;
    private double ResisEquivalente;
    private double ResisE;
    private double intensidad;
    private double voltaje;
    //imprimir valores
    public TextMesh NumRes;
    //validar circuito
    public float Primercircuito = 0;
    public float Segundoci = 0;
    public GameObject boton;
    private bool presionado;
    public bool estado;
    public bool estadoI;
    //validar panel 
    public int Resis560;
    public int Resis1;
    public int CableRojo;
    public int CableAzul;

    public Text Cont560k;
    public Text Cont1k;
    public Text Cont47k;
    public Text ContCableR;
    public Text ContCableA;
    public GameObject Bresi560;
    public GameObject Bresi1K;
    public GameObject Breis47k;
    public GameObject BCableRojo;
    public GameObject BcableAzul;
    public GameObject BMetodoDirecto;
    public GameObject BMetodoIndirecto;
    public GameObject BListoMD;
    public GameObject BListoMI;


    void Start()
    {
        //calculando tolerancia
        Tolerancia = Math.Round(UnityEngine.Random.Range(95f, 106f));
        Tolerancia = Tolerancia / 100;
        //multiplicando por k
        R1 = R1 * 1000 * Tolerancia;
        R2 = R2 * 1000 * Tolerancia;
        R3 = R3 * 1000 * Tolerancia;
        R4 = R4 * 1000 * Tolerancia;
        R5 = R5 * 1000 * Tolerancia;

        //Disminuir errores
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        //inicializar componente y estadp de boton 
        componentesCircuitosConectado = 0;
        this.presionado = boton.GetComponent<PresionDeBoton>().estaPresionado();
    }


    void Update()
    {
        //validar conexion 
        if (componentesCircuitosConectado != 17 || componentesCircuitosConectado != 19)
        {
            NumRes.text = "0.00" + " Ω";
        }
        estado = MovimientoPerillaMultimetro.obteneropcion5();
        estadoI = MovimientoPerillaMultimetro.obteneropcion7();


        this.presionado = boton.GetComponent<PresionDeBoton>().estaPresionado();
        VlidarConexionCircuito();
        ValidarPanel();
    }

    public void ConstruccionCircuito()
    {
        componentesCircuitosConectado++;
        Debug.Log(componentesCircuitosConectado);
    }
    public void VlidarConexionCircuito()
    {

        if (componentesCircuitosConectado == 17 && Primercircuito == 4 && Segundoci == 0 && estado == true)
        {
            CalcularRes();
            BListoMD.GetComponent<Image>().color=Color.green;
            Debug.Log(ResisEquivalente);
        }
        else if (componentesCircuitosConectado == 19 && Primercircuito == 2 && Segundoci == 4 && !presionado && estadoI == true)
        {
            CalcularRes();
            CalcularIntensidad();
            BListoMI.GetComponent<Image>().color=Color.green;
            Debug.Log(intensidad);
        }
        else
        {
            NumRes.text = "0.00" + " Ω";
            BListoMD.GetComponent<Image>().color=Color.red;
            BListoMI.GetComponent<Image>().color=Color.red;
        }
    }

    public void CalcularRes()
    {
        ResisEquivalente = (1 / R1) + (1 / R2) + (1 / R3) + (1 / R4) + (1 / R5);
        ResisEquivalente = 1 / ResisEquivalente;
        ResisEquivalente = Math.Round(ResisEquivalente, 2);
        NumRes.text = "" + ResisEquivalente + " Ω";
    }
    public void CalcularIntensidad()
    {
        voltaje = MostrandoVoltaje.obtenerTotalVoltaje();
        intensidad = voltaje / ResisEquivalente;
        intensidad = intensidad * 100;
        intensidad = Math.Round(intensidad, 2);
        NumRes.text = "" + intensidad + " mA";
    }

    public void DesconexionCircuito()
    {
        Debug.Log(componentesCircuitosConectado);
        componentesCircuitosConectado--;
        if (componentesCircuitosConectado != 17 || componentesCircuitosConectado != 19)
        {
            NumRes.text = "0.00" + " Ω";
        }
    }
    public void ValidarPanel()
    {
        if (Resis560 == 2)
        {
            Bresi560.GetComponent<Image>().color = Color.green;
        }
        else
        {
            Bresi560.GetComponent<Image>().color = Color.red;
        }
        if (Resis1 == 2)
        {
            Bresi1K.GetComponent<Image>().color = Color.green;
        }
        else
        {
            Bresi1K.GetComponent<Image>().color = Color.red;
        }
        if (CableRojo == 4)
        {
            BCableRojo.GetComponent<Image>().color = Color.green;
        }
        else
        {
            BCableRojo.GetComponent<Image>().color = Color.red;
        }
        if (CableAzul == 4)
        {
            BcableAzul.GetComponent<Image>().color = Color.green;
        }
        else
        {
            BcableAzul.GetComponent<Image>().color = Color.red;
        }
        if (componentesCircuitosConectado == 17 && Primercircuito == 4 && Segundoci == 0)
        {
            BMetodoDirecto.GetComponent<Image>().color=Color.green;
        }
        else if (componentesCircuitosConectado == 19 && Primercircuito == 2 && Segundoci == 4)
        {
           BMetodoIndirecto.GetComponent<Image>().color=Color.green;
        }
        else{
            BMetodoDirecto.GetComponent<Image>().color=Color.red;
            BMetodoIndirecto.GetComponent<Image>().color=Color.red;
        }
        
     
    }
    public void validarPrimeroC()
    {
        Primercircuito++;
        Debug.Log(Primercircuito);
    }
    public void validarPrimeroCRes()
    {
        Primercircuito--;
        Debug.Log(Primercircuito);
    }
    public void validarSegunC()
    {
        Segundoci++;
        Debug.Log(Segundoci);
    }
    public void validarSegnRes()
    {
        Segundoci--;
        Debug.Log(Segundoci);
    }
    // validar panel 
    public void Resistencia560()
    {
        Resis560++;
        Cont560k.text = "" + Resis560;
        Debug.Log(Resis560);
    }
    public void Resistencia560Res()
    {
        Resis560--;
        Cont560k.text = "" + Resis560;
        Debug.Log(Resis560);
    }
    public void Resistencia1()
    {
        Resis1++;
        Cont1k.text = "" + Resis1;
        Debug.Log(Resis1);
    }
    public void Resistencia1Res()
    {
        Resis1--;
        Cont1k.text = "" + Resis1;
        Debug.Log(Resis1);
    }
    public void Resistencia47()
    {
        Cont47k.text = "" + 1;
        Breis47k.GetComponent<Image>().color = Color.green;
    }
    public void Resistencia47Res()
    {
        Cont47k.text = "" + 0;
        Breis47k.GetComponent<Image>().color = Color.red;
    }
    public void CableProtoRojo()
    {
        CableRojo++;
        ContCableR.text = "" + CableRojo;
        Debug.Log(CableRojo);
    }
    public void CableProtoRojoRes()
    {
        CableRojo--;
        ContCableR.text = "" + CableRojo;
        Debug.Log(CableRojo);
    }
    public void CableProtoAzul(){
        CableAzul++;
        ContCableA.text=""+CableAzul;
        Debug.Log(CableAzul);
    }
    public void CableProtoAzulRes(){
        CableAzul--;
        ContCableA.text=""+CableAzul;
        Debug.Log(CableAzul);
    }



}

