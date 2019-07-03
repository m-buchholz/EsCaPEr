using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneIfNotFinished : MonoBehaviour
{

    private Button button;
    public string scene;
    public GameObject fox;

    // Start is called before the first frame update
    void Start()
    {
        // include buttons
        button = GetComponent<Button>();
        button.onClick.AddListener(changeScene);
    }

    private void changeScene()
    {
        if (scene == "Last_Scene") scene = PlayerPrefs.GetString("Last_Scene");
        if (PlayerPrefs.GetInt(scene) == 0)
        {
            Initiate.Fade(scene, Color.black, 10f);
            PlayerPrefs.SetString("Last_Scene", SceneManager.GetActiveScene().name);
        }
        else
        {
            fox.GetComponentInChildren<Text>().text = PlayerPrefs.GetString("Minigame_finished");
            fox.SetActive(true);
        }
    }
}
