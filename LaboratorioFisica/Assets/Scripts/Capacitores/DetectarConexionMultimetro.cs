using System.Collections;
using UnityEngine;

public class DetectarConexionMultimetro : MonoBehaviour
{
    DetectarCircuitoTerminado multimetro;
    // Start is called before the first frame update
    void Start()
    {
        multimetro = GetComponentInParent<DetectarCircuitoTerminado>();
    }

    private void OnTriggerEnter(Collider other) {
        if(multimetro!=null){
            multimetro.conexionesMulti++;
        }
        
        AdminCapacitores.instance.ConexionMultimetro();
        //Debug.Log("Cable conectado");
    }

    private void OnTriggerExit(Collider other) {
        if(multimetro!=null){
            multimetro.conexionesMulti--;
        }
        
        AdminCapacitores.instance.DesconexionMultimetro();
        //Debug.Log("Cable desconectado");
    }
}
