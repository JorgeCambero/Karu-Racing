using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Gearbox", menuName = "Gearbox")]
public class GearboxBase : ScriptableObject
{
    [SerializeField]private float[] gearRatios;
    [SerializeField] private float finalDrive;
    [SerializeField] private int gear,tractionType;
    private WheelCollider[] wheels;
    
    public float[] GearRatios { get => gearRatios; }
    public float FinalDrive { get => finalDrive; }
    public int Gear { set => gear = value; get => gear; }
    public int TractionType { get => tractionType; }

    
    
    public float GetGearing() 
    {
        return gearRatios[gear] * finalDrive;
    }
   
}
