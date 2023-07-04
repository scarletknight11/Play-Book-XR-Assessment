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

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.F))
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.G))
        {
            transform.Translate(Vector3.back * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.localScale -= new Vector3(0.01f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.X))
        {
            this.transform.localScale -= new Vector3(0f, 0.01f, 0f);
        }

        if (Input.GetKey(KeyCode.C))
        {
            this.transform.localScale -= new Vector3(0f, 0f, 0.01f);
        }

        if (Input.GetKey(KeyCode.V))
        {
            this.transform.localScale += new Vector3(0.01f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.B))
        {
            this.transform.localScale += new Vector3(0f, 0.01f, 0f);
        }

        if (Input.GetKey(KeyCode.N))
        {
            this.transform.localScale += new Vector3(0f, 0f, 0.01f);
        }
    }
}
