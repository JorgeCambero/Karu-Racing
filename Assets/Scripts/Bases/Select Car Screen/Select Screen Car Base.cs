using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectScreenCarBase : MonoBehaviour
{
    [SerializeField] PowerTrainBase powerTrain;
    [SerializeField] string carName,enginePos;
    [SerializeField] int hp;
    [SerializeField] Vector3 selectScreenPos,selectScreenScale;
    [SerializeField] GameObject carModel;
    string tractionType;
    public string CarName { get => carName; }
    public int HP { get => hp; }
    public string TracType { get => tractionType; }
    void Start()
    {
        switch (powerTrain.Gearbox.TractionType)
        {
            case 0:
                tractionType = "FWD";
                break;
            case 1:
                tractionType = "RWD";
                break;
            case 2:
                tractionType = "AWD";
                break;
        }
        carModel.transform.localPosition = selectScreenPos;
        carModel.transform.localScale = selectScreenScale;
    }
    // Update is called once per frame
    
}
