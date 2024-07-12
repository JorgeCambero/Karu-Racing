using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] Canvas pauseMenu;
    [SerializeField] AudioManager uiAudio;
    [Space] [SerializeField] InputActionAsset myActions;
    public InputAction pause;
    
    void Start()
    {
        pause = myActions.FindAction("Car Control/Pause");
    }

    void Update()
    {
        if (pause.triggered && pauseMenu.isActiveAndEnabled) 
        {
            uiAudio.playSound(4);
            Time.timeScale = 1.0f;
            pauseMenu.gameObject.SetActive(false);
            

        }
        else if(pause.triggered && !pauseMenu.isActiveAndEnabled) 
        {
            Time.timeScale = 0.0f;
            pauseMenu.gameObject.SetActive(true);
            uiAudio.playSound(3);
        }
    }
    public void ToCarSelect() 
    {
        uiAudio.playSound(1);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Car Select");
    }

    public void Restart()
    {
        uiAudio.playSound(1);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("test");
    }
}
