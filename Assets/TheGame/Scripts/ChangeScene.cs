using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public Button button;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(changeScene);
    }

    private void changeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
