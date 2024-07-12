using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public Image acc, brek, lDir, rDir, rpmVis;
    public TextMeshProUGUI motorT, speed, gear;
    private float a,b;
    PowerTrainBase powerTrain;
    [SerializeField] CarController playerCarC;
    GameObject playerCar;
    [SerializeField] Color TacBase, TacFinal;
    // Start is called before the first frame update
    void Start()
    {
        playerCar = GameObject.FindWithTag("Player");
        playerCarC = playerCar.GetComponentInChildren<CarController>();
        powerTrain = playerCarC.powerTrain[0];
    }

    // Update is called once per frame
    void Update()
    {
        
        if (powerTrain.Gearbox.Gear != -1) {
            a = Mathf.Abs((powerTrain.Engine.Rpm / powerTrain.Gearbox.GearRatios[powerTrain.Gearbox.Gear] / powerTrain.Gearbox.FinalDrive) * playerCarC.wheels[0].radius * 2 * 0.1885f);
        }
        else { a = 0;  }

        
        gear.SetText(Mathf.RoundToInt(powerTrain.Engine.Rpm).ToString());
        speed.SetText(Mathf.RoundToInt(a).ToString());

        acc.fillAmount = playerCarC.Accelerate.ReadValue<float>();
        brek.fillAmount = playerCarC.Brake.ReadValue<float>();
        rpmVis.fillAmount = (powerTrain.Engine.Rpm - 0) / (powerTrain.Engine.TqCurve[powerTrain.Engine.TqCurve.Length-1].rpm - 0);
        
        rpmVis.color = Color.Lerp(TacBase,TacFinal,rpmVis.fillAmount);
        
       
        if (playerCarC.Turn.ReadValue<float>() > 0.0f)
        {
            rDir.fillAmount = playerCarC.Turn.ReadValue<float>();
            lDir.fillAmount = 0.0f;
        }
        else
        {
            lDir.fillAmount = -playerCarC.Turn.ReadValue<float>();
            rDir.fillAmount = 0.0f;
        }

        if (powerTrain.Gearbox.Gear != -1)
        {
            b = powerTrain.Gearbox.Gear + 1;
            if (powerTrain.Gearbox.Gear < powerTrain.Gearbox.GearRatios.Length - 1)
            {
                motorT.SetText(b.ToString());
            }
            else
            {
                motorT.SetText("R");
            }
        }
        else
        {
            motorT.SetText("N");
        }

    }
}
