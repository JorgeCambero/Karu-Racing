using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    WheelHit hit;
    WheelCollider wheel;
    TyreBase tyre;
    WheelFrictionCurve tempFFric;
    WheelFrictionCurve tempSFric;
    // Start is called before the first frame update
    void Start()
    {
        wheel = GetComponent<WheelCollider>();
        tyre = GetComponentInParent<CarController>().setup[0].Tyre;
    }
    private void Update()
    {
        var grounded = wheel.GetGroundHit(out hit);
        if (grounded)
        {            
            string collTag = hit.collider.tag;
            switch (collTag) 
            {
                case "road":
                    tempFFric = tyre.FnormalCurve;
                    tempSFric = tyre.SnormalCurve;
                    
                    wheel.forwardFriction = tempFFric;
                    wheel.sidewaysFriction = tempSFric;
                    break;
                case "wet":
                    tempFFric = tyre.FnormalCurve;
                    tempSFric = tyre.SnormalCurve;

                    tempFFric.stiffness = tyre.FWetStiff;
                    tempSFric.stiffness = tyre.SWetStiff;

                    wheel.forwardFriction = tempFFric;
                    wheel.sidewaysFriction = tempSFric;
                    break;
                case "gravel":
                    tempFFric = tyre.FdirtCurve;
                    tempSFric = tyre.SdirtCurve;

                    wheel.forwardFriction = tempFFric;
                    wheel.sidewaysFriction = tempSFric;
                    break;
            }
            
        }

    }
        

    
}
