using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneSceneSalleAManger : MonoBehaviour
{
    private LevelManager _levelManager;

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }


   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("key")){
            _levelManager.LoadAsyncScene(LevelManager.Scene.SceneSalleAManger);
        Debug.Log("trigger fonctionne");
        }
        
    }
}
