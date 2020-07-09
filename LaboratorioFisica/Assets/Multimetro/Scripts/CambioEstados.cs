using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEstados : MonoBehaviour
{
    //Eliminen esto ahora que hay una mejor manera de cambiar la perilla.
    public Animator agujaAnimatorController;
    // Start is called before the first frame update
    void Start()
    {
        agujaAnimatorController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            agujaAnimatorController.SetBool("abierto", true);
        }
        else
        {
            agujaAnimatorController.SetBool("abierto", false);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            agujaAnimatorController.SetBool("fuga", true);
        }
        else
        {
            agujaAnimatorController.SetBool("fuga", false);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            agujaAnimatorController.SetBool("cortocircuitado", true);
        }
        else
        {
            agujaAnimatorController.SetBool("cortocircuitado", false);
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            agujaAnimatorController.SetBool("operativo", true);
        }
        else
        {
            agujaAnimatorController.SetBool("operativo", false);
        }
    }
}
