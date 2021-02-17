using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnowballs : MonoBehaviour
{
    private GameObject cameraObj;
    public GameObject snowballPrefab;
    //preferred method
    //the game object this script is attached to is already available by default

    // Start is called before the first frame update
    void Start()
    {
        //snowballPrefab = GameObject.Find("Snowball");
        //more brittle method since if you rename in the editor, this breaks
        cameraObj = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject snowball = Instantiate(snowballPrefab, transform.position, transform.rotation);
            //float speed = 3.0f; // must always declare type before a variable name

            //take target x,y,z minus source x,y,z to get the vector from source towards target
            //this is the manual method, Unity has a "look at" function for doing this
            //Vector3 vectorToTarget = cameraObj.transform.position - transform.position;
            //vectorToTarget = vectorToTarget.normalized;
            //snowball.transform.forward = vectorToTarget;

            snowball.transform.LookAt(cameraObj.transform); // multiply by -1 to move away
            
            
        }
        */
        
        // preview of what we do here:
        // check for keypress
        // if yet:
        //  Instantiate(snowballPrefab, position)
        
    }

    public void SpawnSnowball() // must be public if you want to access it from the editor, e.g. to attach to a button
    {
        GameObject snowball = Instantiate(snowballPrefab, transform.position, transform.rotation);

        snowball.transform.LookAt(cameraObj.transform); // multiply by -1 to move away

    }
}
