using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("lilypad"))
        {
            // Different lillypads have different bounce forces assigned
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * collision.gameObject.GetComponent<RingScript>().bounceForce); // 1000.0f
        }
    }
}
