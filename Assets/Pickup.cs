using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pickup")
        {

            //set the color of the object to red

            float indexTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
            if (indexTrigger != 0.0f)
            {
                SetColor otherColor = other.gameObject.GetComponent<SetColor>();
                otherColor.SetGreen();

            }


            //check if i have pinched OR if the controller button has gone down while i have gone over

            //pickup the object by turning off its rigidbody and then moving it to the position of the hand

        }
    }
}
