using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        float moveSpeed = 10.0f;
        float rotateSpeed = 20.0f;

        // TRANSLATE

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= Vector3.forward * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position -= Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.position -= Vector3.up * moveSpeed * Time.deltaTime;
        }


        //ROTATE

        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Rotate(-1.0f * rotateSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(rotateSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(0.0f, rotateSpeed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(0.0f, -1.0f * rotateSpeed * Time.deltaTime, 0.0f);
        }
       
    }
}
