using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnloadAdditiveScene : MonoBehaviour
{
    public Button button;
    public string unloadScene;
    public string loadScene = "";

    void Start()
    {
        button.onClick.AddListener(unloadMyScene);
    }

    private void unloadMyScene()
    {
        SceneManager.UnloadSceneAsync(unloadScene);
        if (loadScene != "") loadMyScene();
    }

    private void loadMyScene()
    {
        SceneManager.LoadScene(loadScene);
    }
}
