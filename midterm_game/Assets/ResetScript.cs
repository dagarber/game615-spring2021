using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{

    float xInit;
    float yInit;
    float zInit;

    // Start is called before the first frame update
    void Start()
    {
        xInit = gameObject.transform.position.x;
        yInit = gameObject.transform.position.y;
        zInit = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
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
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        gameObject.transform.position = new Vector3(xInit + posRangeX, yInit + posRangeY, zInit + posRangeZ);
        gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
