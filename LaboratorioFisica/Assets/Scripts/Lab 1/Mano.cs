using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mano : MonoBehaviour {
    public Vector3 initialPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //OBTENER LOS VALORES DE PRESIONAR TECLAS ARRIBA Y ABAJO, Y MOVER EL OBJETO SEGUN ESOS VALORE
        //VERIFICACNFO MARGENES
        var xMov = Input.GetAxis("Horizontal");
        var yMov = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(xMov, yMov, 0f));
        verifyMargins();
    }

    public void repositionate()
    {
        transform.localPosition = initialPosition;
    } 

    //CUADRO DE MARGEN X, Y
    public void verifyMargins()
    {
        #region X Position
        if (transform.localPosition.x > -3.0f)
        {
            transform.localPosition = new Vector3(-3.0f, transform.localPosition.y, transform.localPosition.z);
        }else if (transform.localPosition.x < -7.6f)
        {
            transform.localPosition = new Vector3(-7.6f, transform.localPosition.y, transform.localPosition.z);
        }
        #endregion
        #region Y Position
        if (transform.localPosition.y > 6.4f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 6.4f, transform.localPosition.z);
        }
        else if (transform.localPosition.y < 0.226f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 0.226f , transform.localPosition.z);
        }
        #endregion

    }
}
