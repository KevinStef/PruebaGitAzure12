using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControladorPuntaPrueba : MonoBehaviour {
    public GameObject prefabMarca;
    public GameObject PosicionText;
    public GameObject Lector;
    public float minX,maxX,minZ,maxZ;
    public float totalZ,totalX;
    public float X, Z;
    public GameObject[] Marcas;
    private GameObject m;

    // Use this for initialization

    void Start () {
        totalZ = maxZ - minZ;
        totalX = maxX - minX;
    }

    // Update is called once per frame
    void Update() {
        //LECTURA DE FLECHAS Y MARGEN DE MOVIMIENTO

        var x = Input.GetAxis("Horizontal") * Time.deltaTime;
        var y = Input.GetAxis("Vertical") * Time.deltaTime;
        if (x > 0)
        {
            if(transform.position.x < maxX+0.25)
            {
                transform.Translate(new Vector3(-x, 0, 0));
            }
        }
        if (x < 0)
        {
            if (transform.position.x > minX-0.2)
            {
                transform.Translate(new Vector3(-x, 0, 0));
            }
        }
        if (y > 0)
        {
            if (transform.position.z < maxZ)
            {
                transform.Translate(new Vector3(0, 0, y));
            }
        }
        if (y < 0)
        {
            if (transform.position.z > minZ)
            {
                transform.Translate(new Vector3(0, 0, y));
            }
        }
        
        //4 Y 9 SON LOS MAXIMOS DEL TAPER HOJA MILIMETRADA , DX DZ SON LOS DIFERENCIALES Y LOS 8 Y 18 EL TOATL DEL TAPER
        var dz = (transform.position.z - minZ)/totalZ;
        Z = (8 * dz)-4 ;
        var dx = (transform.position.x - minX) /totalX;
        X = (18 * dx)-9 -0.0658f  + 0.004f + 0.000145f;

        //escribir posicion
        string pocision = "[" + X.ToString("#.##") + ":" + Z.ToString("#.##") + "]";
        PosicionText.GetComponent<TextMesh>().text = pocision;

        //SI CLICK EN BARRA SPACE
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Marcar(Lector.transform.position);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Desmarcar();
        }
    }

    //REOGE LA POSICION DE LA AGUJA Y instancia un objeto en su posicion y llama marcar posicion del componente marca
    //para escribir posición
    private void Marcar(Vector3 position)
    {
        m = GameObject.Instantiate(prefabMarca, position, Quaternion.identity);
        m.GetComponent<Marca>().pocisionMarcada(new Vector2(X, Z));

        //Marcas = new GameObject[100];
        //if (Marcas.Length == 0)
        //{
        //    Marcas[0] = GameObject.Instantiate(prefabMarca, position, Quaternion.identity);
        //    Marcas[0].GetComponent<Marca>().pocisionMarcada(new Vector2(X, Z));
        //}
        //else if (Marcas.Length < 100) {
        //    Marcas[Marcas.Length] = GameObject.Instantiate(prefabMarca, position, Quaternion.identity);
        //    Marcas[Marcas.Length].GetComponent<Marca>().pocisionMarcada(new Vector2(X, Z));
        //}
    }

    private void Desmarcar(){
        //for (int i = Marcas.Length; i >= 0; i--)
        //for (int i = 0; i < 100; i++)
      //  {

        //    //Marcas[i] = null;
        //GameObject.Destroy(Marcas[i]);
        //    //Marcas[i].GetComponent<MeshRenderer>().enabled=false;
         GameObject.Destroy(m);
       // }
        // GameObject.Destroy(prefabMarca);

        Debug.Log("no funciona setactive");
    }

}
