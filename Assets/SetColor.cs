using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{

    Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGreen()
    {
        r.material.color = Color.green;

        //build an thread the loops through colour until its green from red.

    }

    public void SetRed()
    {
        r.material.color = Color.red;

    }
}
