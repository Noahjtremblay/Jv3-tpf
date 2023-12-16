using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using System;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Image _progressBar;

    public static LevelManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Exterieur_V2.ToString());
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.SceneDepart.ToString());
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public async void LoadAsyncScene(Scene sceneName)
    {
        var sceneLoad = SceneManager.LoadSceneAsync(sceneName.ToString());
        sceneLoad.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);

        do
        {
            await Task.Delay(100);
            _progressBar.fillAmount = sceneLoad.progress;

        } while (sceneLoad.progress < 0.9f);

        sceneLoad.allowSceneActivation = true;
        _loaderCanvas.SetActive(false);
    }

    public enum Scene
    {
        SceneDepart,
        Exterieur_V2,
        SceneSalleAManger,
        Cuisine,
        BreakRoom
    }
}
