using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimbalTest : MonoBehaviour {

    float x;
    float y;
    float z;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            x += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(x, y, z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            x += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(-x,y,z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            y += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(x, y, z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            y += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(x, -y, z);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            z += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(x, y, z);
        }

        if (Input.GetKey(KeyCode.E))
        {
            z += Time.deltaTime * 100.0f;
            transform.rotation = Quaternion.Euler(x, y, -z);
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
