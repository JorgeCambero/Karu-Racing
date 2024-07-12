using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[CreateAssetMenu(fileName ="PowerTrain",menuName ="PowerTrain")]
public class PowerTrainBase : ScriptableObject
{

    [SerializeField] private EngineBase engine;
    [SerializeField] private GearboxBase gearbox;
    
    [SerializeField] private WheelCollider[] wheels;
    [SerializeField] private InputAction acc;
    [SerializeField] private float pwTrainInertia;
    public EngineBase Engine { get => engine; }
    public GearboxBase Gearbox { get => gearbox; }

    public InputAction Acc { set => acc = value; }
    public WheelCollider[] Wheels { set => wheels = value; }
    public PowerTrainBase(EngineBase engine,GearboxBase gearbox,float pwTrainInertia,WheelCollider[]wheels,InputAction Accelerate) 
    {
        this.engine = engine;
        this.gearbox = gearbox;
        this.wheels = wheels;
        this.pwTrainInertia = pwTrainInertia;
        this.acc = Accelerate;

    }

    
    public float GetPwWheelRPM()
    {
        float wheelRPM = 0;
        switch (gearbox.TractionType)
        {
            case 0:
                wheelRPM = Mathf.Abs((wheels[0].rpm + wheels[1].rpm) / 2f) * gearbox.GetGearing();
                break;
            case 1:
                wheelRPM = Mathf.Abs((wheels[2].rpm + wheels[3].rpm) / 2f) * gearbox.GetGearing();
                break;
            case 2:
                wheelRPM = Mathf.Abs((wheels[0].rpm + wheels[1].rpm + wheels[2].rpm + wheels[3].rpm) / 4f) * gearbox.GetGearing();
                break;
        }
        return Mathf.Abs(wheelRPM);
    }
    public float GetPwWheelRotSpeed()
    {
        float wheelRPM = 0;
        switch (gearbox.TractionType)
        {
            case 0:
                wheelRPM = Mathf.Abs((wheels[0].rotationSpeed + wheels[1].rotationSpeed) / 2f) ;
                break;                                                    
            case 1:                                                       
                wheelRPM = Mathf.Abs((wheels[2].rotationSpeed + wheels[3].rotationSpeed) / 2f) ;
                break;                                                    
            case 2:                                                       
                wheelRPM = Mathf.Abs((wheels[0].rotationSpeed + wheels[1].rotationSpeed + wheels[2].rotationSpeed + wheels[3].rotationSpeed) / 4f) ;
                break;
        }
        return Mathf.Abs(wheelRPM);
    }
    public void SimulatePowerTrain()
    {        
        if (gearbox.Gear == -1)
        {
            engine.Rpm = Mathf.Lerp(engine.Rpm, Mathf.Max(engine.TqCurve[0].rpm, (engine.TqCurve[engine.TqCurve.Length - 1].rpm + 200f) * acc.ReadValue<float>()) + Random.Range(-50, 50), Time.deltaTime * engine.EngineInertia);
        }
        else
        {
            float wheelRPM = GetPwWheelRPM();
            if (wheelRPM > engine.TqCurve[engine.TqCurve.Length-1].rpm + 200f ) 
            {
                wheelRPM = engine.TqCurve[engine.TqCurve.Length - 1].rpm + 200f + Random.Range(-50, 50);
            }

            engine.Rpm = Mathf.Lerp(engine.Rpm, Mathf.Max(engine.TqCurve[0].rpm, wheelRPM), Time.deltaTime * pwTrainInertia);
        }
    }
    public void CheckMaxWheelSpeed()
    {
        if (gearbox.Gear != -1)
        {
            float wheelRotSpeed = GetPwWheelRotSpeed();
            
            
            if (wheelRotSpeed > engine.TqCurve[engine.TqCurve.Length - 1].rpm / Mathf.Abs(gearbox.GetGearing()) * 6)
             {
                

                 switch (gearbox.TractionType)
                 {
                     case 0:
                         
                         wheels[0].rotationSpeed = wheels[1].rotationSpeed = (engine.TqCurve[engine.TqCurve.Length - 1].rpm - 150) / gearbox.GetGearing() * 6; 
                         
                         break;
                     case 1:
                        
                         wheels[2].rotationSpeed = wheels[3].rotationSpeed = (engine.TqCurve[engine.TqCurve.Length - 1].rpm - 150)  / gearbox.GetGearing() * 6;
                         break;
                     case 2:
                         wheels[0].rotationSpeed = wheels[1].rotationSpeed = wheels[2].rotationSpeed = wheels[3].rotationSpeed = (engine.TqCurve[engine.TqCurve.Length - 1].rpm - 150) / gearbox.GetGearing() * 6;
                        break;
                 }


             }
        }
    }
}
