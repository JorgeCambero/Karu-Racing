using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraManager : MonoBehaviour
{
    [SerializeField] private InputActionAsset myActions;
    public InputAction ChangeCam,LookBack, LookLeft, LookRight;
    [SerializeField] Camera MainCam;
    [SerializeField] GameObject targetCar;
    [Space] [SerializeField] GameObject[] cams;
    
    int camID = 0;
    int auxCamID = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        AdjustCam();
        LookLeft = myActions.FindAction("Car Control/LookLeft");
        LookRight = myActions.FindAction("Car Control/LookRight");
        ChangeCam = myActions.FindAction("Car Control/ChangeCam");
        LookBack = myActions.FindAction("Car Control/LookBack");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(ChangeCam.triggered) 
        {
            
            if (camID < cams.Length-4) 
            {
                camID = camID+4;
                AdjustCam();
                auxCamID = camID;
            }
            else 
            {
                camID = 0;
                AdjustCam();
                auxCamID = camID;
            }
            
        }
        
        if (LookLeft.WasPressedThisFrame()&& !(LookBack.ReadValue<float>() > 0.1f)) 
        {
            if (camID < cams.Length - 1) 
            {
                camID = camID + 1;
                AdjustCam();
            }
                
        }

        if (LookRight.WasPressedThisFrame() && !(LookBack.ReadValue<float>() > 0.1f)) 
        {

            if (camID < cams.Length - 2)
            {
                camID = camID + 2;
                AdjustCam();
            }
        }

        if(LookBack.WasPressedThisFrame() && !(LookRight.ReadValue<float>() > 0.1f) && !(LookLeft.ReadValue<float>() > 0.1f))
        {
            if (camID < cams.Length - 3)
            {
                camID = camID + 3;
                AdjustCam();
            }
        }

        if (wasReleased()) 
        {
            camID = auxCamID;
            AdjustCam();
        }


        if(camID != 8) 
        {
            MainCam.transform.LookAt(targetCar.transform);
        }
        

    }
    private void AdjustCam() 
    {
        
        MainCam.transform.position = cams[camID].transform.position;
        
    }
    private bool wasReleased() 
    {
        return LookLeft.WasReleasedThisFrame() || LookRight.WasReleasedThisFrame() || LookBack.WasReleasedThisFrame();
    }
    
}
