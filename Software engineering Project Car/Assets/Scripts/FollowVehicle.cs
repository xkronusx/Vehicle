using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVehicle : MonoBehaviour {

    public GameObject myCamera;
    public GameObject myVehicle;
    // Use this for initialization
    void Start()
    {
        myCamera.transform.Rotate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        myCamera.transform.position = myVehicle.transform.position + new Vector3(0, 45, -50);
    }
}
