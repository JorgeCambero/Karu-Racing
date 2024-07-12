using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCarSpawner : MonoBehaviour
{
    string[] cars;
    
    // Start is called before the first frame update
    void Awake()
    {
        cars = AssetDatabase.FindAssets("t:prefab", new[] { "Assets/Prefabs/Player Car" });
        Vector3 SpawnPos = transform.position;
        var path = AssetDatabase.GUIDToAssetPath(cars[CarSelector.CarSelected]);
        var car = AssetDatabase.LoadAssetAtPath(path, typeof(GameObject)) as GameObject;
        Instantiate(car, SpawnPos ,transform.rotation); 
    }

    
}
