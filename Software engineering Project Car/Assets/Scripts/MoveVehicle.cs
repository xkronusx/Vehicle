using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour {

    private Rigidbody rb;
    public GameObject spherePlayer;
    private Vector3 jump = new Vector3(0, 300, 0);
    private Vector3 maxHeight = new Vector3(0, 200, 0);
    private Vector3 startPos = new Vector3(0, 0, 0);
    private float speed = 30f;
    public bool landed = true;

   
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  

    

    // Update is called once per frame
    void Update()
    {


        if (landed == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("1");
                landed = false;
                rb.AddForce(jump);    
            }
        }


        /*
        if (spherePlayer.transform.position.x > 300 || spherePlayer.transform.position.x < -100 || spherePlayer.transform.position.y < -50)
        {
            spherePlayer.transform.position = startPos;
            rb.velocity = Vector3.zero;
        }*/

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed);
        }
    }
}