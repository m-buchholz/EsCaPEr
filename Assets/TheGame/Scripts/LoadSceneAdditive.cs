using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneAdditive : MonoBehaviour
{
    public Button button;
    public string scene;

    void Start()
    {
        button.onClick.AddListener(loadScene);
    }

    private void loadScene()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }
}
