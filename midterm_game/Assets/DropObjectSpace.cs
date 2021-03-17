using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObjectSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnTriggerEnter(Collider other)
    void OnCollisionEnter(Collision other)
    {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>(); // uppercase GameObject is the class, gameObject is the instance
            rb.useGravity = true;
    }

}
