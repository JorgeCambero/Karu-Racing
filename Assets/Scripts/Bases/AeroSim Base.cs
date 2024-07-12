using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeroSimBase : MonoBehaviour
{
    [SerializeField] Rigidbody carRB;
    [SerializeField] float surfaceA, dragCO, aeroCO;
    [SerializeField] bool aero;
    [SerializeField] GameObject center;
    // Start is called before the first frame update
    void Start()
    {
        carRB.centerOfMass = center.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        carRB.drag = (0.5f * 1.225f * carRB.velocity.magnitude * surfaceA * dragCO)/1000;
        carRB.angularDrag = carRB.drag ;
        if (aero) { carRB.AddForce(new Vector3(0, -aeroCO * carRB.velocity.sqrMagnitude, 0)); }
    }
}
