using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class LevelManager : MonoBehaviour
{

    [SerializeField] private GameObject _loaderCanvas;


    [SerializeField] private Image _progressBar;

    public static LevelManager Instance;

      private void Awake()
    {

        if(Instance == null){//est ce qu'il existe
            Instance = this;//l'objet sur lequel tu es en ce moment this //il existe pas donc on le met dedans

            DontDestroyOnLoad(gameObject); //pour ne pas détruire l'objet il va rester la.
        }

        else{

            Destroy(gameObject);
        }
         
    }

    public void LoadScene(string scene){
         SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame(){
        SceneManager.LoadScene(Scene.Exterieur.ToString());
    }

    public void LoadMainMenu(){

        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

    public void QuitGame(){
        Application.Quit();
    }

    public async void LoadAsyncScene(Scene sceneName){ //temps d'attente pour scen pour faire le progress bar

        var sceneLoad = SceneManager.LoadSceneAsync(sceneName.ToString());
        sceneLoad.allowSceneActivation = false;

    _loaderCanvas.SetActive(true);
        do{
            await Task.Delay(300);

            _progressBar.fillAmount = sceneLoad.progress;
        }while (sceneLoad.progress < 0.9f);
        
        sceneLoad.allowSceneActivation = true;
         _loaderCanvas.SetActive(false);
    }


    public enum Scene{

        MainMenu, 
        Exterieur, 

        
        SceneSalleAManger

       
    }
}
