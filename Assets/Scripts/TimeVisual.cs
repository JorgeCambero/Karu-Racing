using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeVisual : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI acLap, lastLap;
    [SerializeField] TextMeshProUGUI[] sectors;
    [SerializeField]TimerManager time;
    // Start is called before the first frame update
    void Start()
    {
        
        acLap = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        acLap.SetText(time.TimerComponents(time.Tme));
        
    }
    public void LastLapUpdater() 
    {
        lastLap.SetText(time.TimerComponents(time.LatestLap));
        if (time.LatestLap < time.LastLap) 
        {
            lastLap.color = Color.green;
        }
        else
        {
            lastLap.color = Color.red;
        }
    }

    public void SectorUpdater(int i) 
    {
        ColorSec(i);
        sectors[i].SetText(time.TimerComponents(time.timerSectors[i]));
    }
    private void ColorSec(int i) 
    {
        if (time.timerSectors[i] < time.lastLapSectors[i]) 
        {
            sectors[i].color=Color.green;
        }
        else 
        {
            sectors[i].color = Color.red;
        }
    }
}
