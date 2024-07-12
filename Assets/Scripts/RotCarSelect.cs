using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCarSelect : MonoBehaviour
{
    [SerializeField] Rigidbody rbBase;
    [SerializeField] float rotSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rbBase.angularVelocity = new Vector3(0, rotSpeed, 0);
    }
}
