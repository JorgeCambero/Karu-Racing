using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CarSelector : MonoBehaviour
{
    static int carSelected;
    //[SerializeField] static int nCars;
    GameObject cilinderBase;
    string[] cars;
    [Space] [SerializeField]  InputActionAsset myActions;
     public InputAction up,down,left,right,confirm,cancel;
    public static int CarSelected { get => carSelected; }
    [SerializeField] SlctCarCanvasManager canvas;
    [SerializeField] AudioManager uiAudio;
    
    
    private void Awake()
    {
        
        left = myActions.FindAction("Select Screen/LEFT");
        right = myActions.FindAction("Select Screen/RIGHT");
        confirm = myActions.FindAction("Select Screen/Confirm");
    }
    void Start()
    { 
        cilinderBase = this.gameObject;
        cars = AssetDatabase.FindAssets("t:prefab", new [] { "Assets/Prefabs/Select Screen Car" });
        var path = AssetDatabase.GUIDToAssetPath(cars[carSelected]);
        var car = AssetDatabase.LoadAssetAtPath(path, typeof(GameObject));
        Instantiate(car,cilinderBase.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if(left.triggered && carSelected > 0 ) 
        {
            carSelected--;
            Destroy(cilinderBase.transform.GetChild(0).gameObject);
            SpawnCar(carSelected);
            canvas.ChangedData();
            uiAudio.playSound(0);
        }

        if (right.triggered && carSelected < cars.Length-1)
        {
            carSelected++;
            Destroy(cilinderBase.transform.GetChild(0).gameObject);
            SpawnCar(carSelected);
            canvas.ChangedData();
            uiAudio.playSound(0);
        }

        if (confirm.triggered) 
        {
            uiAudio.playSound(1);
            
            SceneManager.LoadScene("Test"); 

        }

    }
    private void SpawnCar(int i) 
    {
        var path = AssetDatabase.GUIDToAssetPath(cars[i]);
        var car = AssetDatabase.LoadAssetAtPath(path, typeof(GameObject));
        Instantiate(car, cilinderBase.transform);
    }
}
