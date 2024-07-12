using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Car Setup", menuName = "Car Setup")]
[System.Serializable]
public class CarSetupBase : ScriptableObject
{
    
    [SerializeField] float fAntiRoll,rAntiRoll;
    [SerializeField] TyreBase tyres;
    public TyreBase Tyre { get => tyres; }
    public float FAR { get => fAntiRoll; set => fAntiRoll = value; }
    public float RAR { get => rAntiRoll; set => rAntiRoll = value; }
}
