using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Engine", menuName = "Engine")]
public class EngineBase : ScriptableObject
{
    [SerializeField]private TorquePoints[] tqCurve ;
    [SerializeField]private float engineInertia;
    private float rpm;
    
    public float Rpm { get => rpm; set => rpm = value; }
    
    public TorquePoints[] TqCurve { get => tqCurve; }
    
    public float EngineInertia { get => engineInertia; }

    public EngineBase(TorquePoints[] tqCurve,float engineInertia) 
    {
        this.tqCurve = tqCurve;
               
        
        this.engineInertia = engineInertia;
    }

    public float GetRange()
    {


        for (int i = 0; i < tqCurve.Length; i++)
        {
            if (rpm <= tqCurve[tqCurve.Length - 1].rpm  && rpm >= tqCurve[0].rpm)
            {
                if (rpm < tqCurve[i].rpm)
                {
                    return CalcTorque(tqCurve[i - 1].torque, tqCurve[i].torque, tqCurve[i - 1].rpm, tqCurve[i].rpm, rpm);
                }
            }
            else if (rpm < tqCurve[0].rpm)
            {
                return tqCurve[0].torque;
            }
            else if (rpm > tqCurve[tqCurve.Length - 1].rpm)
            {
                return 0.0f;
            }
        }
        return 0.0f;
    }

    public float CalcTorque(float pw0, float pw1, float rpm0, float rpm1, float aCRPM)
    {
        return (pw1 - pw0) / (rpm1 - rpm0) * (aCRPM - rpm0) + pw0;
    }

    


    
    
}
