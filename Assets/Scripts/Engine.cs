using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
public class Engine : MonoBehaviour
{
    public WheelCollider FL, FR, RL, RR;
    public float torque,scaleFact,engineSpeed,rpm, a, b, finalDrive;
    public int n = 0, tqCurveLength;
    public Image acc, brek,lDir,rDir, rpmVis;
    public TextMeshProUGUI motorT, speed,gear;
    public AudioSource engineSound;
    [Space] [SerializeField] private InputActionAsset myActions;
    public InputAction Accelerate,Turn,Brake,up,down,handBrake;
    public float[,] tqCurve;
    public float[] gearRatios;
    float minPitch = 0.75f, maxPitch = 2.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        tqCurveLength = 12;
        rpm = 1050;
        tqCurve = new float[tqCurveLength,2];
        gearRatios = new float[6];
        tqCurve[0,0] = 950;
        tqCurve[0,1] = 75.5f;
        tqCurve[1,0] = 1500;
        tqCurve[1,1] = 113.3f;
        tqCurve[2,0] = 2000;
        tqCurve[2,1] = 132.2f;
        tqCurve[3,0] = 2500;
        tqCurve[3,1] = 143.5f;
        tqCurve[4,0] = 3000;
        tqCurve[4,1] = 151.1f;
        tqCurve[5,0] = 3500;
        tqCurve[5,1] = 156.5f;
        tqCurve[6,0] = 4000;
        tqCurve[6,1] = 160.5f;
        tqCurve[7,0] = 4500;
        tqCurve[7,1] = 163.7f;
        tqCurve[8,0] = 5000;
        tqCurve[8,1] = 164.5f;
        tqCurve[9,0] = 5500;
        tqCurve[9,1] = 160.3f;
        tqCurve[10,0] = 6000;
        tqCurve[10,1] = 152f;
        tqCurve[11,0] = 6500;
        tqCurve[11,1] = 133.4f;

        gearRatios[0] = 2.923f;
        gearRatios[1] = 1.85f;
        gearRatios[2] = 1.36f;
        gearRatios[3] = 1.069f;
        gearRatios[4] = 0.865f;
        gearRatios[5] = -3.333f;

        finalDrive = 3.688f;

        Accelerate = myActions.FindAction("Car Control/Accelerate");
        Turn = myActions.FindAction("Car Control/Turn");
        Brake = myActions.FindAction("Car Control/Brake");
        up = myActions.FindAction("Car Control/Up Shift");
        down = myActions.FindAction("Car Control/Down Shift");
        handBrake = myActions.FindAction("Car Control/HandBrake");
    }

    private void FixedUpdate()
    {
        if (n != -1) 
        {
            float wheelSpeed = Mathf.Abs((FR.rpm + FL.rpm) / 2f) * gearRatios[n] * finalDrive;
            
            if (wheelSpeed > tqCurve[tqCurveLength - 1, 0] + 700)
            {
                
                //FR.brakeTorque = FL.brakeTorque = float.PositiveInfinity;
                FR.rotationSpeed = tqCurve[tqCurveLength - 1, 0] * Mathf.PI / 30;
                FL.rotationSpeed = tqCurve[tqCurveLength - 1, 0] * Mathf.PI / 30;
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        engineSound.pitch = (maxPitch-minPitch)*(rpm/tqCurve[tqCurveLength-1,0])+minPitch;
        
        SimulateEngine();
        

        if (up.triggered && n < gearRatios.Length-1) { n++; }
        if (down.triggered && n > -1) { n--; }
        
        ////////////////////////////////////////////////////////////////////
        ///
        if (n != -1)
        {
           
            FR.motorTorque = GetRange(rpm) * gearRatios[n] * finalDrive * Accelerate.ReadValue<float>() * 0.5f;
            FL.motorTorque = GetRange(rpm) * gearRatios[n] * finalDrive * Accelerate.ReadValue<float>() * 0.5f;
            
        }
        
        


        FR.steerAngle = FL.steerAngle = Turn.ReadValue<float>() * scaleFact;
        
        FR.brakeTorque = FL.brakeTorque = torque * 0.6f * Brake.ReadValue<float>();
        if (handBrake.ReadValue<float>() > 0.0f)
        {
            RL.brakeTorque = RR.brakeTorque = float.PositiveInfinity;
        }
        else
        {
            RL.brakeTorque = RR.brakeTorque = torque * 0.4f * Brake.ReadValue<float>();
        }



    }
    public float GetRange(float acRPM) 
    {
        
        
        for (int i = 0; i < tqCurveLength; i++)
        {

            if (acRPM <= tqCurve[tqCurveLength-1, 0] + 100 && acRPM >= tqCurve[0, 0])
            {
                
                if (acRPM < tqCurve[i, 0])
                {
                    return CalcTorque(tqCurve[i - 1, 1], tqCurve[i, 1], tqCurve[i - 1, 0], tqCurve[i, 0], acRPM);
                }


            }
            else if (acRPM < tqCurve[0, 0])
            {
                return tqCurve[0, 1];
            }
            else if(acRPM > tqCurve[tqCurveLength-1, 0])
            {
                return 0.0f;
            }
            
            
            
        }
        return 0.0f;
    }
    
    public float CalcTorque(float pw0, float pw1, float rpm0, float rpm1,float aCRPM) 
    {
        return (pw1-pw0)/(rpm1-rpm0)*(aCRPM-rpm0) + pw0;
    }
    

    public void SimulateEngine() 
    {
        
            if (n == -1) 
            {
                rpm = Mathf.Lerp(rpm, Mathf.Max(tqCurve[0,0],tqCurve[tqCurveLength - 1,0] * Accelerate.ReadValue<float>() )+Random.Range(-50,50),Time.deltaTime*5f);
            }
            else 
            {
               
                float wheelRPM = Mathf.Abs((FR.rpm + FL.rpm) / 2f)* gearRatios[n] * finalDrive;
                
                wheelRPM = Mathf.Abs(wheelRPM);
                if (wheelRPM> tqCurve[tqCurveLength - 1, 0] + 100) 
                {
                    wheelRPM = tqCurve[tqCurveLength - 1, 0] ;
                    
                }
               
                rpm = Mathf.Lerp(rpm, Mathf.Max(tqCurve[0, 0], wheelRPM), Time.deltaTime * 3f);
                
            }

        
        
        
    }
}
