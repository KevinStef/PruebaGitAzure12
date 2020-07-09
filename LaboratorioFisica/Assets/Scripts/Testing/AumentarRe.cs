using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarRe : MonoBehaviour {
    GameObject getTarget;
    Vector3 offsetValue;
    Vector3 positionOfScreen; 
public int actual;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            getTarget = ReturnClickedObject(out hitInfo);
            if (getTarget != null)
            {
                positionOfScreen = Camera.main.WorldToScreenPoint(getTarget.transform.position);
                int modifier = 0;
                switch (getTarget.name)
                {
                    case "+": modifier = 1;
                        break;
                    case "-": modifier = -1;
                        break;
                }
                
                    actual += modifier;
                if (actual < -6)
                {
                    actual = -6;
                }else if(actual>6)
                {
                    actual = 6;
                }
            }

        }
        pintar(actual);
	}

    private void pintar(int act)
    {
        this.GetComponent<TextMesh>().text = act+"";
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
