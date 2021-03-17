using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript2 : MonoBehaviour
{
    public GameObject startButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopScript() // must be public if you want to access it from the editor, e.g. to attach to a button
    {

        //start = true;
        GameObject[] GOs = GameObject.FindGameObjectsWithTag("lilypad");
        for (int i = 0; i < GOs.Length; i++)
        {
            // Another option was to enable/disable the motion script assigned to the objects
            //GOs[i].GetComponent<RingScript>().enabled = true;
            //if (GOs[i].GetComponent<RingScript>().startCheck == true)
            //{
            //     GOs[i].GetComponent<RingScript>().startCheck = false;
            //}
            //else
            //{

            GOs[i].GetComponent<RingScript>().startCheck = false;

            //}

        }
        gameObject.SetActive(false);
        startButton.SetActive(true);

    }
}
