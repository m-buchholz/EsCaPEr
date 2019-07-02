using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMinigame : MonoBehaviour
{

    private Button button;
    public string scene;
    public GameObject fox;
    public Text foxText;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(changeScene);
    }

    private void changeScene()
    {
        if (PlayerPrefs.GetInt("MW") == 1 && !fox.activeSelf)
        {
            if (scene == "Last_Scene") scene = PlayerPrefs.GetString("Last_Scene");
            Initiate.Fade(scene, Color.black, 10f);
            PlayerPrefs.SetString("Last_Scene", SceneManager.GetActiveScene().name);
            if (GameObject.Find("Background Audio") != null) GameObject.Find("Background Audio").GetComponent<AudioSource>().UnPause();
        }
        else
        {
            // warning: if open pause menu, minigame resets
            foxText.text = PlayerPrefs.GetString("MW_T");
            PlayerPrefs.SetInt("MW", 1);
            fox.SetActive(true);
        }
    }
}
