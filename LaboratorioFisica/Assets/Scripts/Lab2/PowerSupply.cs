//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class PowerSupply : MonoBehaviour {

//    public GameObject Switch;
//    public GameObject plusV;
//    public GameObject numVoltaje;
//    public GameObject minusV;
//    public GameObject ModMng;
//    private GameObject getTarget;
//    public bool power;

//    public GameObject ElectrodoObj;



//    // Use this for initialization
//    void Start() {

//    }

//    // Update is called once per frame
//    void Update() {



//        numVoltaje.GetComponent<TextMesh>().text = ModMng.GetComponent<LecturaCampo>().getVoltage() + ".00";


//        if (Input.GetMouseButton(0))
//        {
//            RaycastHit hitInfo;
//            getTarget = ReturnClickedObject(out hitInfo);

//            if (power != true) //la cosa esta apgada
//            {
//                if (getTarget.name == Switch.name)
//                {
//                    power = true;
//                    Switch.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
//                }

//            }
//            else
//            {
//                if (getTarget.name == plusV.name)
//                {
//                    ModMng.GetComponent<LecturaCampo>().increaseVoltaje();
//                }
//                else if (getTarget.name == minusV.name)
//                {
//                    ModMng.GetComponent<LecturaCampo>().reduceVoltage();
//                }
//                else if (getTarget.name == Switch.name)
//                {
//                    power = false;
//                    ModMng.GetComponent<LecturaCampo>().setVoltage(0);
//                    Switch.GetComponent<Renderer>().material.color = new Color(1, 0, 0);

//                }
//                else {////////// 

//                }

//        }
//            GameObject ReturnClickedObject(out RaycastHit hit)
//            {
//                GameObject target = null;
//                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//                if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
//                {
//                    target = hit.collider.gameObject;
//                }
//                return target;
//            }
//        }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerSupply : MonoBehaviour
{
    public GameObject Switch;
    public GameObject plusV;
    public GameObject numVoltaje;
    public GameObject minusV;
    public GameObject ModMng;
    private GameObject getTarget;
    public bool power;
    
    public GameObject ElectrodoObj;

    private bool loquesea;
    public double voltaje;

    // Use this for initialization
    void Start()
    {
        //power = true;
        //Switch.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {


        numVoltaje.GetComponent<TextMesh>().text = ModMng.GetComponent<LecturaCampo>().getVoltage() + ".00";

        voltaje = ModMng.GetComponent<LecturaCampo>().getVoltage();
      

        if (Input.GetMouseButton(0))
        {
            RaycastHit hitInfo;
            getTarget = ReturnClickedObject(out hitInfo);

            if (power == true)
            {
                if (getTarget != null)
                {

                    switch (getTarget.name)
                    {

                        case "Plus":
                            ModMng.GetComponent<LecturaCampo>().increaseVoltaje();
                            break;
                        case "Minus":
                            ModMng.GetComponent<LecturaCampo>().reduceVoltage();
                            break;
                       

                        default: goto eso; break;
                    }



                    //if (getTarget.name == plusV.name)
                    //{
                    //    ModMng.GetComponent<LecturaCampo>().increaseVoltaje();
                    //}
                    //if (getTarget.name == minusV.name)
                    //{
                    //    ModMng.GetComponent<LecturaCampo>().reduceVoltage();
                    //}
                    //else
                    //{
                    //    power = false;
                    //}
                }
                else loquesea = false;
                //SceneManager.LoadScene(0);
            }
            else
                goto eso;
        }

        eso:
        {
            //este es para prender y apagara
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hitInfo;
                getTarget = ReturnClickedObject(out hitInfo);
                if (getTarget != null)
                {
                    if (getTarget.name == Switch.name)
                    {
                        if (power == true)
                        {
                            power = false;
                            ModMng.GetComponent<LecturaCampo>().setVoltage(0);
                            Switch.GetComponent<Renderer>().material.color = new Color(1, 0, 0);

                        }
                        else
                        {
                            power = true;
                            Switch.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
                        }
                    }
                    if (getTarget.name == "Marca(Clone)") GameObject.Destroy(getTarget);
                }
            }
        }
    }
    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}