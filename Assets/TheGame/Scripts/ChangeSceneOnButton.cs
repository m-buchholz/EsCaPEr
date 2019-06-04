using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneOnButton : MonoBehaviour
{

    public Button button;
    public int scene;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ChangeScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
