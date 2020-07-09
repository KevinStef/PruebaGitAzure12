using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voltimetro : MonoBehaviour
{

    public float voltaje;

    public float intensidadC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Resistencia.obtenerIntesidad());
    }

    private void OnTriggerEnter(Collider other){

         if (other.gameObject.CompareTag("cable2")){

            this.voltaje = other.GetComponent<Cables3>().obtenerVoltaje5();
            this.intensidadC = other.GetComponent<Cables3>().obtenerResistencia();

        }

    }


}
