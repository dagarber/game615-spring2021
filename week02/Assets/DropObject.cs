using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.AddForce(transform.right * -500.0f);  // FORWARD = Z (BLUE ARROW), RIGHT = X (RED ARROW), UP = Y (GREEN ARROW), LEFT-HANDED COORDINATE SYSTEM

        }
    }
}
