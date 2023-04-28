using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleP2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //p2
        if (Input.GetKey(KeyCode.Z))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 4);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * 4);
        }
    }
}
