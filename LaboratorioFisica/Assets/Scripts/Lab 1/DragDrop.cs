using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{

    //Initialize Variables
    GameObject getTarget;
    bool isMouseDragging;
    Vector3 offsetValue;
    Vector3 positionOfScreen;
    public GameObject mdManager;
    public GameObject hand;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        //PESATS CLICKEADO ALGO Y LA POSICION DE LA CAMARA VASRIARA Y S E GUARDARAN
        //Mouse Button Press Down
        if (Input.GetMouseButtonDown(0))
        {
            ModuleManager mdMng = mdManager.GetComponent<ModuleManager>();
            //COPIA DE MNMANAGER
            RaycastHit hitInfo;
            //COPIAS LO QUE ESTAS CLICKEANDO
            getTarget = ReturnClickedObject(out hitInfo);
            //SI ESTAS CLICKEANDO ALGO Y NO A AL NADA
            if (getTarget != null)
            {
                //mdManager.GetComponent<ModuleManager>().cambiarSeleccion(getTarget.transform.name);
                isMouseDragging = true;
                //MOVER LA PANTALLA A LA POSICION DEL OBJETO CLICKEADO
                //Converting world position to screen position.
                positionOfScreen = Camera.main.WorldToScreenPoint(getTarget.transform.position);

                offsetValue = getTarget.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionOfScreen.z));
                //VECTO3= POSICION DEL OBJETO CLICKEADO - LA POSISCION DE LA CAMARA  QUE ES LO MISMO Q DECIR POSCION DEL MOUSE
            }
        }

        //SE SUELTA EL CLICK Y SE DEBE CAER LAS VARILLAS Q ESTES PRESIONADO
        //Mouse Button Up
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDragging = false;
            if (getTarget != null)
            {
                //SI EL OBJETO CLICKEADO TIENE LAYER 8(VARILASS) Y TIERNEN FISICAS 
                if (getTarget.layer == 8 && getTarget.GetComponent<Rigidbody>() != null)
                {
                    getTarget.GetComponent<Rigidbody>().useGravity = true;
                    //ENTOCES LA FISICA DE LA VARILLA DE PLASTICO O VIDRIO ACTIVARA LA GRAVEDSD-PARA QUE SE CAIGA.
                }
            }
        }

        //SI SE SIGUE CLICKEANDO ALGO ENTONCES SE GUARDARA LA POSICION DEL MUSE Y LA POSICION DE LA CAMARA ACTUALMENTE + 
        //POSICION DEL OBJETO CLICKEADO - LA POSISCION DE LA CAMARA  QUE ES LO MISMO Q DECIR POSCION DEL MOUSE
        //Is mouse Moving
        if (isMouseDragging)
        {
            //tracking mouse position.
            Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, positionOfScreen.z);

            //converting screen position to world position with offset changes.
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offsetValue;

            //It will update target gameobject's current postion.
            //SI LO CLICKEADO ES UNA DE LAS VSAARILLAAS ENTCS SE MOVERA LA VARILLA A LA POSICION DE LA CAMARA ACTUALMENTE + 
            //POSICION DEL OBJETO CLICKEADO - LA POSISCION DE LA CAMARA  QUE ES LO MISMO Q DECIR POSCION DEL MOUSE
            //Y SE DEJARA DE APLICAR GRAVEDAD EN VARIOLA
            if (getTarget.layer == 8)
            {
                getTarget.transform.position = currentPosition;
                getTarget.GetComponent<Rigidbody>().useGravity = false;
            }
        }



    }

    //Method to Return Clicked Object
    GameObject ReturnClickedObject(out RaycastHit hit)
    {
           GameObject target = null;
        //UN SET DE ACTUALES  COORDENADAS DEL MOUSE
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            //show the name of the item that player is hitting with raycast
            target = hit.collider.gameObject;
        }
        return target;
    }

}
