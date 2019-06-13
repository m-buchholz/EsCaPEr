using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    private Button button;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(changeScene);
    }

    private void changeScene()
    {
        if (scene == "") scene = PlayerPrefs.GetString("last_Scene");
        Initiate.Fade(scene, Color.black, 10f);
        // SceneManager.LoadScene(scene);

        PlayerPrefs.SetString("last_Scene", SceneManager.GetActiveScene().name);        
    }
}
