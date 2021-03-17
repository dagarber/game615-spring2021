using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogFed : MonoBehaviour
{

    [HideInInspector] public bool frogFed = false;
    public GameObject rewardText;
    public Material frogFedMat;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(frogFed == false)
        {
            return;
        }

        if (timer > 5)
        {
            rewardText.SetActive(false);
            Debug.Log("YES!");
            return;
            //frogFed = false;
        }


        gameObject.GetComponent<MeshRenderer>().material = frogFedMat;
        rewardText.SetActive(true);
        timer += Time.deltaTime;


        
    }


    //This function is called once per frame and it draws User Interface elements.
    //Don't worry too much about this right now, but it is useful to get our force
    //printing to the screen.

    /*
    private void OnGUI() // redraws every frame
    {
        GUI.Label(new Rect(50, 50, 200, 200), launchForce.ToString());

        if (playerWon)
        {
            GUI.Label(new Rect(250, 250, 200, 200), "You win!");
        }
    }
    */

}
