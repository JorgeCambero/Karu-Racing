using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] float FslipT,SslipT;
    Vector3  pos;
    Quaternion  rot;
    [SerializeField] WheelCollider[] wheels = new WheelCollider[4];
    [SerializeField] GameObject[] wheelsModel = new GameObject[4];
    [SerializeField] GameObject[] wheelsSmoke = new GameObject[4];
    AudioSource[] tyreSound = new AudioSource[4];
    WheelHit wheelHit = new WheelHit();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < wheelsSmoke.Length; i++) 
        {
            tyreSound[i] = wheelsSmoke[i].GetComponent<AudioSource>();
        }


    }
    void CheckSlip() 
    {
        
        for (int i = 0; i < wheels.Length; i++) 
        {
            if (wheels[i].GetGroundHit(out wheelHit)) 
            {
                bool Fslip = (wheelHit.forwardSlip > FslipT || wheelHit.forwardSlip < -FslipT);
                bool Sslip = (wheelHit.sidewaysSlip > SslipT || wheelHit.sidewaysSlip < -SslipT);
                if (Fslip || Sslip) 
                { 
                    wheelsSmoke[i].GetComponent<TrailRenderer>().emitting = true;
                    if (!tyreSound[i].isPlaying) { tyreSound[i].Play(); }
                }
                else 
                {
                    wheelsSmoke[i].GetComponent<TrailRenderer>().emitting = false;
                    tyreSound[i].Stop();

                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < wheels.Length; i++) 
        {
            CheckSlip();
            wheels[i].GetWorldPose(out pos, out rot);
            wheelsModel[i].transform.position = pos;
            if(i % 2 == 0) 
            { 
                wheelsModel[i].transform.rotation = rot * Quaternion.Euler(0, 0, 90);
            }
            else 
            {
                wheelsModel[i].transform.rotation = rot * Quaternion.Euler(0, 0, -90);
            }
            
            wheelsSmoke[i].transform.position = pos - new Vector3(0, wheels[i].radius - 0.01f, 0);
        }
        

    }
}
