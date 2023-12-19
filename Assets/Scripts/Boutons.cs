using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boutons : MonoBehaviour
{

    private LevelManager _LevelManager;

    // Start is called before the first frame update
    void Start()
    {
        _LevelManager = LevelManager.Instance;
    }

    public void StartNewGame()
    {
        _LevelManager.LoadAsyncScene(LevelManager.Scene.Exterieur_V2);
    }

    public void QuitGame()
    {
        _LevelManager.QuitGame();
    }

    public void RestartGame(){

        _LevelManager.LoadAsyncScene(LevelManager.Scene.SceneDepart);
    }
}