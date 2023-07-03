using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOverride : MonoBehaviour {

    public Vector3 euler;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            euler.x += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(euler.x, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            euler.x += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(-euler.x, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            euler.y += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(0.0f, euler.y, 0.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            euler.y += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(0.0f, -euler.y, 0.0f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            euler.z += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, euler.z);
        }

        if (Input.GetKey(KeyCode.E))
        {
            euler.z += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, -euler.z);
        }
    }
}
