using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingScript : MonoBehaviour
{
	public bool startCheck = false; // private by default --> public static makes one for all
    public float bounceForce;

	float moveTimer;
	float moveTimerOrig;
	float moveSpeed = 0.05f;

	// Start is called before the first frame update
	void Start()
	{
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
