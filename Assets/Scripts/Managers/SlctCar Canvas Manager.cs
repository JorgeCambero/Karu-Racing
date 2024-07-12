using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SlctCarCanvasManager : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI carName, carHP, carTracType;
    [SerializeField]GameObject selectorCilinder;
    Transform car;
    SelectScreenCarBase carData;
    
    void Update()
    {
        if(car == null) 
        {
            ChangedData();
        }
    }
    public void ChangedData() 
    {
        if (selectorCilinder.transform.childCount > 0)
        {
            car = selectorCilinder.transform.GetChild(0);
            carData = car.GetComponent<SelectScreenCarBase>();
            carName.SetText(carData.CarName);
            carHP.SetText("Power: " + carData.HP.ToString()+"HP");
            carTracType.SetText("Traction: " + carData.TracType);
        }
    }
}
