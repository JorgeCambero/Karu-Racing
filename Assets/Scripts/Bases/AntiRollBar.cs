using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiRollBar : MonoBehaviour
{
    [SerializeField]WheelCollider WheelL, WheelR ;
    
    [SerializeField]float antiRoll = 5000.0f;
    public float Antiroll { set => antiRoll=value; }

    void FixedUpdate()
    {
        WheelHit hit;
        float travelL = 1.0f;
        float travelR = 1.0f;

        var groundedL = WheelL.GetGroundHit( out hit);
        if (groundedL)
        {
            travelL = (-WheelL.transform.InverseTransformPoint(hit.point).y - WheelL.radius) / WheelL.suspensionDistance;
        }
        else 
        {
            travelL = 1.0f;
        }



        var groundedR = WheelR.GetGroundHit(out hit);
        if (groundedR) 
        {
            travelR = (-WheelR.transform.InverseTransformPoint(hit.point).y - WheelR.radius) / WheelR.suspensionDistance;
        }
        else 
        {
            travelR = 1.0f;
        }
            

        float antiRollForce = (travelL - travelR) * antiRoll;

        GetComponentInParent<Rigidbody>().AddForceAtPosition(WheelL.transform.up * -antiRollForce,
                   WheelL.transform.position);
        
        
        GetComponentInParent<Rigidbody>().AddForceAtPosition(WheelR.transform.up * antiRollForce,
                   WheelR.transform.position);
    }
}
