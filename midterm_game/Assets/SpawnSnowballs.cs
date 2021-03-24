using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSnowballs : MonoBehaviour
{
    public GameObject cameraObj;
    public GameObject snowballPrefab;
    public Text launchForceText;
    float launchForce = 3000f;
    float launchForceOrig;

    // Start is called before the first frame update
    void Start()
    {
        launchForceOrig = launchForce;
    }

    // Update is called once per frame
    void Update()
    {
        launchForceText.text = launchForce.ToString();

        if (Input.GetKeyDown(KeyCode.Return))
        {
            launchForce += 500f;
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            launchForce -= 500f;
        }

        if (Input.GetKeyDown(KeyCode.Space)) // GetKeyDown
        {
            GameObject snowball = Instantiate(snowballPrefab, transform.position, transform.rotation);
            Rigidbody rb = snowball.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.AddForce(transform.forward * launchForce);
            //launchForce = launchForceOrig;

        }
        
        
    }

}
