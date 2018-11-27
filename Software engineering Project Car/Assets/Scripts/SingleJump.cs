using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleJump : MonoBehaviour {
    public int test = 0;



    void OnTriggerEnter(Collider col)
    {

        if (col.GetComponent<TriggerTEST>() != null)
        {
            GetComponent<MoveVehicle>().landed = true;
        }
    }
}
