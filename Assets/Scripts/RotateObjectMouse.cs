using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectMouse : MonoBehaviour {

    float rotSpeed = 20;
    float distance = 10;


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Pressed middle-click.");
        }
    }
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
        transform.RotateAround(Vector3.right, rotY); 
    }


}
