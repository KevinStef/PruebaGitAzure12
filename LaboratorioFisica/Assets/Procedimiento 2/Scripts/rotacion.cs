using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotacion : MonoBehaviour
{
    float rotSpeed = 2;
    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Fire1") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Fire2") * rotSpeed * Mathf.Deg2Rad;
        
        transform.RotateAround(Vector3.up,-rotX);
        transform.RotateAround(Vector3.right, rotY);
        
    }
}
