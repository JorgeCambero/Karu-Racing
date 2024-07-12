using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CarController : MonoBehaviour
{
    public WheelCollider[] wheels = new WheelCollider[4];
    public float bTorque = 600f, scaleFact = 2f;
    DifferentialBase diff;
    [SerializeField] DifferentialBase FrontDiff;
    public float awdRatio = 0.6f;
    public float brakeBias = 0.65f;
    [SerializeField] bool akermann;
    public AudioSource engineSound,GearBoxShift;
    public PowerTrainBase[] powerTrain = new PowerTrainBase[1];
    public CarSetupBase[] setup = new CarSetupBase[1];
    [Space] [SerializeField] private InputActionAsset myActions;
    public InputAction Accelerate, Turn, Brake, up, down, handBrake,reverse;
    private float RearTW, wB;
    [SerializeField]float minPitch = 0.75f, maxPitch = 2.5f;
    [SerializeField] AntiRollBar frontAR, rearAR;
    [SerializeField] GameObject[] brakeLights;
    

    // Start is called before the first frame update
    void Awake()
    {
        
        Accelerate = myActions.FindAction("Car Control/Accelerate");
        Turn = myActions.FindAction("Car Control/Turn");
        Brake = myActions.FindAction("Car Control/Brake");
        up = myActions.FindAction("Car Control/Up Shift");
        down = myActions.FindAction("Car Control/Down Shift");
        handBrake = myActions.FindAction("Car Control/HandBrake");
        reverse = myActions.FindAction("Car Control/Reverse");
        powerTrain[0].Wheels = wheels;
        powerTrain[0].Acc = Accelerate;
        diff = this.GetComponent<DifferentialBase>();
        RearTW = Mathf.Abs(wheels[2].transform.localPosition.x) + Mathf.Abs(wheels[3].transform.localPosition.x);
        wB = Mathf.Abs(wheels[0].transform.localPosition.z) + Mathf.Abs(wheels[2].transform.localPosition.z);

        setSetup();
        setDiffWheels();

    }
    
    

    // Update is called once per frame
    void Update()
    {
        
        //Engine Stuff
        powerTrain[0].SimulatePowerTrain();
        //powerTrain[0].CheckMaxWheelSpeed();
        engineSound.pitch = (maxPitch - minPitch) * (powerTrain[0].Engine.Rpm/ powerTrain[0].Engine.TqCurve[powerTrain[0].Engine.TqCurve.Length-1].rpm) + minPitch;
        
        //GEARBOX
        if (up.WasPressedThisFrame() && powerTrain[0].Gearbox.Gear < powerTrain[0].Gearbox.GearRatios.Length - 2) 
        { 
            powerTrain[0].Gearbox.Gear++;
            GearBoxShift.pitch = 1 + Random.Range(-0.5f, 0.1f);
            GearBoxShift.Play();
        }
        if (down.WasPressedThisFrame() && powerTrain[0].Gearbox.Gear > -1) 
        { 
            powerTrain[0].Gearbox.Gear--;
            GearBoxShift.pitch = 1 + Random.Range(-0.5f, 0.1f);
            GearBoxShift.Play();
        }
        if (reverse.triggered) 
        {
            if(powerTrain[0].Gearbox.Gear != powerTrain[0].Gearbox.GearRatios.Length - 1) 
            {
                powerTrain[0].Gearbox.Gear = powerTrain[0].Gearbox.GearRatios.Length - 1;
            }
            else 
            {
                powerTrain[0].Gearbox.Gear = 0;
            }
            
        }

        if (powerTrain[0].Gearbox.Gear != -1)
        {
            switch (powerTrain[0].Gearbox.TractionType)
            {
                case 0:
                    diff.DistributeTorque(powerTrain[0].Engine.GetRange() * powerTrain[0].Gearbox.GetGearing() * Accelerate.ReadValue<float>());
                    break;                           
                case 1:                              
                    diff.DistributeTorque(powerTrain[0].Engine.GetRange() * powerTrain[0].Gearbox.GetGearing() * Accelerate.ReadValue<float>());
                    break;                           
                case 2:
                    FrontDiff.DistributeTorque(powerTrain[0].Engine.GetRange() * powerTrain[0].Gearbox.GetGearing() * Accelerate.ReadValue<float>() * (1f - awdRatio));
                    diff.DistributeTorque(powerTrain[0].Engine.GetRange() * powerTrain[0].Gearbox.GetGearing() * Accelerate.ReadValue<float>() * awdRatio);
                    break;
            }            
        }

        //STEERING
        Steering(akermann);
        

        //BRAKING
        wheels[0].brakeTorque = wheels[1].brakeTorque = bTorque * brakeBias * Brake.ReadValue<float>();
        BrakeLights();
        if (handBrake.ReadValue<float>() > 0.0f)
        {
            wheels[2].brakeTorque = wheels[3].brakeTorque = float.PositiveInfinity;
        }
        else
        {
            wheels[2].brakeTorque = wheels[3].brakeTorque = bTorque * (1f-brakeBias) * Brake.ReadValue<float>();
        }
    }
    void Steering(bool Akermann)
    {
        if (Akermann)
        {
            if (Turn.ReadValue<float>() > 0)
            {
                wheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact + (RearTW / 2))) * Turn.ReadValue<float>();
                wheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact - (RearTW / 2))) * Turn.ReadValue<float>();
            }
            else if (Turn.ReadValue<float>() < 0)
            {
                wheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact - (RearTW / 2))) * Turn.ReadValue<float>();
                wheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact + (RearTW / 2))) * Turn.ReadValue<float>();
            }
            else
            {
                wheels[0].steerAngle = 0f;
                wheels[1].steerAngle = 0f;
            }
        }
        else
        {
            if (Turn.ReadValue<float>() < 0)
            {
                wheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact + (RearTW / 2))) * Turn.ReadValue<float>();
                wheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact - (RearTW / 2))) * Turn.ReadValue<float>();
            }
            else if (Turn.ReadValue<float>() > 0)
            {
                wheels[0].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact - (RearTW / 2))) * Turn.ReadValue<float>();
                wheels[1].steerAngle = Mathf.Rad2Deg * Mathf.Atan(wB / (scaleFact + (RearTW / 2))) * Turn.ReadValue<float>();
            }
            else
            {
                wheels[0].steerAngle = 0f;
                wheels[1].steerAngle = 0f;
            }
        }

    }

    private void setDiffWheels()
    {
        switch (powerTrain[0].Gearbox.TractionType)
        {
            case 0:
                diff.L = wheels[0];
                diff.R = wheels[1];
                break;
            case 1:
                diff.L = wheels[2];
                diff.R = wheels[3];
                break;
            case 2:
                FrontDiff.L = wheels[0];
                FrontDiff.R = wheels[1];
                diff.L = wheels[2];
                diff.R = wheels[3];
                break;
        }
    }

    private void setSetup() 
    {
        setup[0].Tyre.CreateCurves();
        frontAR.Antiroll = setup[0].FAR;
        rearAR.Antiroll = setup[0].RAR;
        for (int i = 0; i < wheels.Length; i++) 
        {
            wheels[i].forwardFriction = setup[0].Tyre.FnormalCurve;
            wheels[i].sidewaysFriction = setup[0].Tyre.SnormalCurve;
        }
    }

    private void BrakeLights() 
    {
        if(Brake.ReadValue<float>() != 0.0f && brakeLights.Length > 0) 
        {
            for(int i = 0; i< brakeLights.Length; i++) 
            {
                brakeLights[i].SetActive(true);
            }
            
        }
        else
        {
            for (int i = 0; i < brakeLights.Length; i++)
            {
                brakeLights[i].SetActive(false);
            }
        }
    }
   
}
