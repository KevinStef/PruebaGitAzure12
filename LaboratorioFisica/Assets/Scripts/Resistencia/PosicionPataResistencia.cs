using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionPataResistencia : MonoBehaviour
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
            PosicionResistencia.contactos++;
            resistencia.GetComponent<PosicionResistencia>().
                numeroGrupos.Add(other.gameObject.GetComponent<CeldaGrupo>().numeroGrupo);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("celda", System.StringComparison.OrdinalIgnoreCase))
        {
            PosicionResistencia.contactos--;
            resistencia.GetComponent<PosicionResistencia>().
                numeroGrupos.Clear();
        }
    }
}
