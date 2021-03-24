using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{
    bool hitLilypad = false;
    bool hitDown = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] frog = GameObject.FindGameObjectsWithTag("frog");
        for (int i = 0; i < frog.Length; i++)
        {
            frog[i].GetComponent<FrogFed>().attempts++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(hitLilypad)
        {
            return;
        }

        if (gameObject.transform.position.z > 60 && hitDown == false)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 1000);
            hitDown = true;
            return;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("lilypad"))
        {
            // Different lillypads have different bounce forces assigned
            hitLilypad = true;
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * collision.gameObject.GetComponent<RingScript>().bounceForce); // 1000.0f
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * collision.gameObject.GetComponent<RingScript>().bounceForce); // 1000.0f

        }

        if (collision.gameObject.CompareTag("frog"))
        {
            // Score the frog encounter
            GameObject frog = collision.gameObject;
            if(frog.GetComponent<FrogFed>().frogFed == true)
            {
                return;
            }

            //if (frog.GetComponent<FrogFed>().frogFed == false)
            //{
                frog.GetComponent<FrogFed>().score++;
                frog.GetComponent<FrogFed>().frogFed = true;
            //}


        }
    }
}
