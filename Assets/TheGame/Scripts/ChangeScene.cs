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
        if (scene == "Last_Scene") scene = PlayerPrefs.GetString("Last_Scene");
        Initiate.Fade(scene, Color.black, 10f);
        PlayerPrefs.SetString("Last_Scene", SceneManager.GetActiveScene().name);
        GameObject.Find("Background Audio").GetComponent<AudioSource>().UnPause();
    }
}
