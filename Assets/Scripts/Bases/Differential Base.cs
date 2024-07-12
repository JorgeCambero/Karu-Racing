using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferentialBase : MonoBehaviour
{
    [SerializeField] int type;
    private WheelCollider l,r ;
    private float leftRes, rightRes;
    private float rTq, lTq;
    
    public WheelCollider L { set => l = value; }
    public WheelCollider R { set => r = value; }
    // Start is called before the first frame update
    WheelHit lHit = new WheelHit();
    WheelHit rHit = new WheelHit();
    public int Type { get => type; set => type = value; }

    private void CalcRes() 
    {        
        if (l.GetGroundHit(out lHit)) 
        {            
            leftRes = Mathf.Clamp01(1 - lHit.forwardSlip);            
        }
        else 
        { leftRes = 0; }
        
        if (r.GetGroundHit(out rHit)) 
        {
            rightRes = Mathf.Clamp01( 1 - rHit.forwardSlip);            
        } 
        else 
        { rightRes =  0; }
    }
    public void DistributeTorque(float engineTq) 
    {
        CalcRes();
        
        float totalRes = leftRes + rightRes;
        if (totalRes <= 0) { totalRes = 0.01f; }
        switch (type) 
        {
            case 0: // Open Diff Tq goes to the wheel with less grip
                 rTq = engineTq *  (leftRes / totalRes);
                 lTq = engineTq * (rightRes / totalRes);
                
                l.motorTorque = lTq;
                r.motorTorque = rTq;
                break;
            case 1: // LSD Diff Tq goes to the wheel whit more grip
                 lTq = engineTq * (leftRes / totalRes);
                 rTq = engineTq * (rightRes / totalRes);

                 l.motorTorque = lTq;
                 r.motorTorque = rTq;
                break;
            case 2: // Welded Diff Tq always split 50/50
                l.motorTorque = engineTq * 0.5f;
                r.motorTorque = engineTq * 0.5f;
                break;
        }
        
    }
}
