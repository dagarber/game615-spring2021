using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{

    //public float speed; // make private if you don't want this to be editable in the editor
    // don't declare a value if you make it public since it will be controlled in the editor
    //private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

        //AddForce(transform.forward * launchForce);
        //transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            float launchForce = -3000f;
            rb.AddForce(transform.forward * launchForce);
        }

        //transform.position = transform.position + transform.forward * speed * Time.deltaTime;


    }
}
