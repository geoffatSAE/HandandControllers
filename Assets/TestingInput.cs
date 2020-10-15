using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingInput : MonoBehaviour
{
    public GameObject cube;
    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = cube.transform.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Controller activeController = OVRInput.GetActiveController();


        float indexTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
        if (indexTrigger != 0.0f)
        {

            r.material.color = Color.blue;
        }


    }
}