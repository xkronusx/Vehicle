using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleJump : MonoBehaviour {
    public int test = 0;
    public GameObject truck;
    void OnTriggerEnter(Collider col)
    {

        if (col.GetComponent<TriggerTEST>() != null)
        {
            truck.GetComponent<MoveVehicle>().landed = true;
            /*
            MoveVehicle mV = col.GetComponent<MoveVehicle>();
            mV.landed = true;
            */
        }
    }
}
