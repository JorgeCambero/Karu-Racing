using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    [SerializeField] AudioSource[] UIsfx;
    // Start is called before the first frame update
    public void playSound(int i) 
    {
        UIsfx[i].Play();
    }
}
