using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingScript : MonoBehaviour
{
	public bool startCheck = false; // private by default, could also do 'public static bool' to create one variable for all instances
    public int bounceForce;
    public Text bounceForceText;

	float moveTimer;
	float moveTimerOrig;
	float moveSpeed = 0.05f;
    float xInit;
    float yInit;
    float zInit;

	// Start is called before the first frame update
	void Start()
	{
        xInit = gameObject.transform.position.x;
        yInit = gameObject.transform.position.y;
        zInit = gameObject.transform.position.z;
		moveTimerOrig = Random.Range(2.0f, 10.0f);
		int[] posNeg = { -1, 1 };
		int posOrNegIndex = Random.Range(0,posNeg.Length);
		Debug.Log("The index value is:" + posOrNegIndex); //  print posOrNegIndex;
        moveSpeed *= posNeg[posOrNegIndex];
        moveTimer = moveTimerOrig / 2;
	}

	// Update is called once per frame
	void Update()
    {
        //Decrement the timer, if it is less than zero, it is time to chenge directions!
        //Debug.Log(start);

        bounceForceText.text = bounceForce.ToString();

        if (startCheck != true)
        {
            return;
        }

        if (moveTimer < 0)
        {
            //Change our move direction by multiplying the speed by -1
            moveSpeed *= -1;

            //Reset the timer
            moveTimer = moveTimerOrig;
        }

        //Move the transform of the gameObject using the "Translate" function
        transform.Translate(moveSpeed, 0, 0);

        moveTimer -= Time.deltaTime;
    }

    public void Reset()
    {
        float posRangeX = Random.Range(2.0f, 10.0f);
        float posRangeZ = Random.Range(2.0f, 10.0f);
        int[] posNeg = { -1, 1 };
        int posOrNegIndexX = Random.Range(0, posNeg.Length);
        int posOrNegIndexZ = Random.Range(0, posNeg.Length);
        posRangeX *= posNeg[posOrNegIndexX];
        posRangeZ *= posNeg[posOrNegIndexZ];
        gameObject.transform.position = new Vector3(xInit + posRangeX, yInit, zInit + posRangeZ);
        int bounceRange = Random.Range(5, 10);
        bounceForce = 100*bounceRange;
        moveTimerOrig = Random.Range(2.0f, 10.0f);
        int posOrNegIndex = Random.Range(0, posNeg.Length);
        //Debug.Log("The index value is:" + posOrNegIndex); //  print posOrNegIndex;
        Debug.Log("The bounce force is:" + bounceForce);
        moveSpeed *= posNeg[posOrNegIndex];
        moveTimer = moveTimerOrig / 2;
    }

    // This was my first attempt at moving the lilypads, this approach did not work
    /*
    public void StartScript() // must be public if you want to access it from the editor, e.g. to attach to a button
	{

		startCheck = true;
		Debug.Log(start);
		Debug.Log("Yes!");

	}
    */
}
