using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marca : MonoBehaviour {
    public GameObject position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pocisionMarcada(Vector2 v)
    {
        string pos = "[" + v[0].ToString("#.##") + ":" + v[1].ToString("#.##") + "]";
        position.GetComponent<TextMesh>().text = pos;
    }

}
