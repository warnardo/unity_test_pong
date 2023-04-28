using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ball_movement : MonoBehaviour
{
    GameObject top; 
    Vector2 upDown = Vector2.down;
    Vector2 leftRight = Vector2.right;
    public float SetXY()
    {
        float pos = Random.Range(-1f, 1f);
        bool run = true;
        if (pos < -0.1 || pos > 0.1)
        {
            while (run) 
            {        
                pos = Random.Range(-1f, 1f); 
                if (pos<-0.1 || pos > 0.1)
                {
                    run = false;
                }
            }
        }


        return pos;
    }
    public int Angle()
    {
        int angle = Random.Range(2, 5);
        return angle;
    }
    // Start is called before the first frame update
    void Start()
    {
        float direct=Random.value;
        if (direct < 0.6 && direct > 0.3)
        {
            upDown = Vector2.zero;
        }  
        else if(direct<0.3)
        {
            upDown = Vector2.up;
        }
        float LR=Random.value;
        if (LR > 0.5)
        {
            leftRight = Vector2.left;
        }
        transform.position = new Vector2(0, 0);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(SetXY(), SetXY()) * 500);
        // Pour X : Si on a 0 à 0,5 > 1 sinon on a 0
        // Pour Y : Même chose


        //GetComponent<Rigidbody>().AddForce (new Vector3 ())
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody2D>().AddForce((leftRight * Angle()) + (upDown * Angle()));

    }
}
