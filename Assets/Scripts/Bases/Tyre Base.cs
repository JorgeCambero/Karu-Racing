using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Tyre", menuName = "Tyre")]
public class TyreBase : ScriptableObject
{
    [SerializeField] string tyreName;
    WheelFrictionCurve fnormalCurve;
    WheelFrictionCurve snormalCurve;
    WheelFrictionCurve fdirtCurve;
    WheelFrictionCurve sdirtCurve;
    
    [SerializeField] float fexSlip, fexValue, fasSlip, fasValue, fnormStiff, fwetStiff, fsnowStiff;
   
    [SerializeField] float fDexSlip, fDexValue, fDasSlip, fDasValue;
    
    [SerializeField] float sexSlip, sexValue, sasSlip, sasValue, snormStiff, swetStiff, ssnowStiff;
    
    [SerializeField] float sDexSlip, sDexValue, sDasSlip, sDasValue;
    public WheelFrictionCurve FnormalCurve { get => fnormalCurve; }
    public WheelFrictionCurve FdirtCurve { get => fdirtCurve; }
    public WheelFrictionCurve SnormalCurve { get => snormalCurve; }
    public WheelFrictionCurve SdirtCurve { get => sdirtCurve; }

    public float FWetStiff { get => fwetStiff; }
    public float FSnowStiff { get => fsnowStiff; }
    public float FNormStiff { get => fnormStiff; }
    public float SWetStiff { get => swetStiff; }
    public float SSnowStiff { get => ssnowStiff; }
    public float SNormStiff { get => snormStiff; }

    public void CreateCurves() 
    {
        fnormalCurve.extremumSlip = fexSlip;
        fnormalCurve.extremumValue = fexValue;
        fnormalCurve.asymptoteSlip = fasSlip;
        fnormalCurve.asymptoteValue = fasValue;
        fnormalCurve.stiffness = fnormStiff;

        fdirtCurve.extremumSlip = fDexSlip;
        fdirtCurve.extremumValue = fDexValue;
        fdirtCurve.asymptoteSlip = fDasSlip;
        fdirtCurve.asymptoteValue = fDasValue;
        fdirtCurve.stiffness = fnormStiff;

        snormalCurve.extremumSlip = sexSlip;
        snormalCurve.extremumValue = sexValue;
        snormalCurve.asymptoteSlip = sasSlip;
        snormalCurve.asymptoteValue = sasValue;
        snormalCurve.stiffness = snormStiff;

        sdirtCurve.extremumSlip = sDexSlip;
        sdirtCurve.extremumValue = sDexValue;
        sdirtCurve.asymptoteSlip = sDasSlip;
        sdirtCurve.asymptoteValue = sDasValue;
        sdirtCurve.stiffness = snormStiff;

    }

}
