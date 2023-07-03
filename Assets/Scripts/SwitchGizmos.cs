using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGizmos : MonoBehaviour {

    public GameObject[] objects;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            objects[0].SetActive(false);
            objects[1].SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.I))
        {
            objects[1].SetActive(false);
            objects[0].SetActive(true);
        }
    }
}
