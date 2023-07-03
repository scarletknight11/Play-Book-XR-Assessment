using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGizmoEmulator : MonoBehaviour {
    
    public enum CoordSystem { Local, Global}
    public CoordSystem coordSystem;
    public float speed = 30.0f;

    // Update is called once per frame
    void Update()
    {
        Quaternion currentRotation = transform.rotation;
        
        if (Input.GetKey(KeyCode.Space))
        {
            coordSystem = CoordSystem.Local;
        }
        if (coordSystem == CoordSystem.Local && Input.GetKey(KeyCode.D))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.right) * currentRotation;
        }
        if (coordSystem == CoordSystem.Local && Input.GetKey(KeyCode.W))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.up) * currentRotation;
        }
        if (coordSystem == CoordSystem.Local && Input.GetKey(KeyCode.S))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, transform.forward) * currentRotation;
        }
        if (Input.GetKey(KeyCode.T))
        {
            coordSystem = CoordSystem.Global;
        }
        if (coordSystem == CoordSystem.Global && Input.GetKey(KeyCode.D))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, new Vector3(1.0f, 0.0f, 0.0f)) * currentRotation;
        }       
        if (coordSystem == CoordSystem.Global && Input.GetKey(KeyCode.W))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, new Vector3(0.0f, 1.0f, 0.0f)) * currentRotation;
        }
        if (coordSystem == CoordSystem.Global && Input.GetKey(KeyCode.S))
        {
            currentRotation = Quaternion.AngleAxis(Time.deltaTime * speed, new Vector3(0.0f, 0.0f, 1.0f)) * currentRotation;
        }

        transform.rotation = currentRotation;
    }
}
