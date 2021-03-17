using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnowballs : MonoBehaviour
{
    public GameObject cameraObj;
    public GameObject snowballPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject snowball = Instantiate(snowballPrefab, transform.position, transform.rotation);
            Rigidbody rb = snowball.GetComponent<Rigidbody>();
            rb.useGravity = true;
            float launchForce = 3000f;
            rb.AddForce(transform.forward * launchForce);

        }
        
        
    }

}
