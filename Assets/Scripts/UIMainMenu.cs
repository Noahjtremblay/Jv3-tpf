using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _newGame;
    [SerializeField] Button _quitGame;

    [SerializeField] Button _restartGame;

    private LevelManager _LevelManager;

    // Start is called before the first frame update
    void Start()
    {
        _LevelManager = LevelManager.Instance;
        if(_newGame != null)_newGame.onClick.AddListener(StartNewGame);
        _quitGame.onClick.AddListener(QuitGame);
        _restartGame.onClick.AddListener(RestartGame);
    }

    private void StartNewGame()
    {
        _LevelManager.LoadAsyncScene(LevelManager.Scene.Exterieur_V2);
    }

    private void QuitGame()
    {
        _LevelManager.QuitGame();
    }

    private void RestartGame(){

        _LevelManager.LoadAsyncScene(LevelManager.Scene.SceneDepart);
    }
}
