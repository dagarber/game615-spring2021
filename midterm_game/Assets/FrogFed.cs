using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogFed : MonoBehaviour
{

    [HideInInspector] public bool frogFed = false;
    public GameObject rewardText;
    public Material frogFedMat;
    float timer = 0;
    private Material frogFedMatOrig;
    float xInit;
    float yInit;
    float zInit;

    // Start is called before the first frame update
    void Start()
    {
        xInit = gameObject.transform.position.x;
        yInit = gameObject.transform.position.y;
        zInit = gameObject.transform.position.z;
        frogFedMatOrig = gameObject.GetComponent<MeshRenderer>().material;
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
            //Debug.Log("YES!");
            //return;
            gameObject.GetComponent<MeshRenderer>().material = frogFedMatOrig;
            frogFed = false;

            GameObject[] GOs = GameObject.FindGameObjectsWithTag("snowball");
            for (int i = 0; i < GOs.Length; i++)
            {
                GOs[i].SetActive(false);
            }

            GameObject[] GO1s = GameObject.FindGameObjectsWithTag("lilypad");
            for (int i = 0; i < GO1s.Length; i++)
            {
                GO1s[i].GetComponent<RingScript>().Reset();
            }

            float posRangeX = Random.Range(2.0f, 10.0f);
            float posRangeY = Random.Range(2.0f, 10.0f);
            float posRangeZ = Random.Range(2.0f, 10.0f);
            int[] posNeg = { -1, 1 };
            int posOrNegIndexX = Random.Range(0, posNeg.Length);
            int posOrNegIndexY = Random.Range(0, posNeg.Length);
            int posOrNegIndexZ = Random.Range(0, posNeg.Length);
            posRangeX *= posNeg[posOrNegIndexX];
            posRangeY *= posNeg[posOrNegIndexY];
            posRangeZ *= posNeg[posOrNegIndexZ];
            gameObject.transform.position = new Vector3(xInit + posRangeX, yInit + posRangeY, zInit + posRangeZ);

            timer = 0;

            return;
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
