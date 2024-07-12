using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecCheck : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TimerManager timer;
    [SerializeField] int position;
    [SerializeField] bool isFinish;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (!isFinish)
            {
                if (timer.AcSec == this.position)
                {
                    
                    timer.nextSect();
                }
            }
            else
            {
                timer.NextLap();
            }
        }  
    }
}
