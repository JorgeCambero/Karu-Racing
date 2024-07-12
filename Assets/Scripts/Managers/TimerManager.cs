using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    int acSec = 1;
    float time,timeMin,timeSec,timeDsec,latestLap;
    float lastLap = float.PositiveInfinity;
    public float[] timerSectors = new float[3];
    public float[] lastLapSectors = new float[3];
    [SerializeField]TimeVisual VisTime;
    public float Tme { get => time; }
    public float LatestLap { get => latestLap; }

    public float LastLap { get => lastLap; }
    public int AcSec { get => acSec; }
    // Start is called before the first frame update
    void Timer()
    {
        time += Time.deltaTime;
        
    }
    private void Start()
    {
        for (int i = 0; i < lastLapSectors.Length; i++)
        {
            lastLapSectors[i] = float.PositiveInfinity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public string TimerComponents(float t) 
    {
        timeMin = Mathf.FloorToInt(t / 60);
        timeSec = Mathf.FloorToInt(t % 60);
        timeDsec = Mathf.FloorToInt((t % 1) * 100);
        return string.Format("{0:00}:{1:00}:{2:00}", timeMin, timeSec, timeDsec);
    }
    public void nextSect() 
    {
        acSec += 1;
        if(acSec == 2) 
        {
            timerSectors[acSec - 2] = time;
        }
        else if (acSec == 4) 
        {
            timerSectors[acSec - 2] = time - timerSectors[acSec - 3]- timerSectors[acSec - 4];
        }
        else  
        {
            timerSectors[acSec - 2] = time - timerSectors[acSec - 3];
        }
        VisTime.SectorUpdater(acSec - 2);  
    }
    public void NextLap() 
    {
        latestLap = time;
        nextSect();
        for (int i = 0; i< timerSectors.Length;i++) 
        {
            lastLapSectors[i] = timerSectors[i]; 
        }
        VisTime.LastLapUpdater();
        lastLap = latestLap;
        acSec = 1;
        time = 0;
    }
}
