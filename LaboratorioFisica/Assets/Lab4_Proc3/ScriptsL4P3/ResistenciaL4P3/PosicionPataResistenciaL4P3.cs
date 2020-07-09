using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionPataResistenciaL4P3 : MonoBehaviour
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
            resistencia.GetComponent<PosicionResistenciaL4P3>().
                numeroGrupos.Add(other.gameObject.GetComponent<CeldaGrupoL4P3>().numeroGrupo);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("celda", System.StringComparison.OrdinalIgnoreCase))
        {
            resistencia.GetComponent<PosicionResistenciaL4P3>().
                numeroGrupos.Clear();
        }
    }
}
