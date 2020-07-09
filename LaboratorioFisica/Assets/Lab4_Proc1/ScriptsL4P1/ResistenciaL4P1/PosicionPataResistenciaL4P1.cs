using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionPataResistenciaL4P1 : MonoBehaviour
{
    public GameObject resistencia;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("celda",System.StringComparison.OrdinalIgnoreCase))
        {
            PosicionResistenciaL4P1.contactos++;
            resistencia.GetComponent<PosicionResistenciaL4P1>().
                numeroGrupos.Add(other.gameObject.GetComponent<CeldaGrupoL4P1>().numeroGrupo);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("celda", System.StringComparison.OrdinalIgnoreCase))
        {
            PosicionResistenciaL4P1.contactos--;
            resistencia.GetComponent<PosicionResistenciaL4P1>().
                numeroGrupos.Clear();
        }
    }
}
