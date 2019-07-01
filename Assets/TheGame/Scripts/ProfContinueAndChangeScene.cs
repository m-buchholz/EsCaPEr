using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfContinueAndChangeScene : MonoBehaviour
{
    private Button button;
    public GameObject objectWithButton;
    public string scene;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(changeScene);
    }

    private void Update()
    {
        if (objectWithButton.activeSelf == true)
        {
            if (Input.GetButtonDown("Jump")) changeScene();
        }
    }

    private void changeScene()
    {
        if (PlayerPrefs.GetInt("Minigame6") == 0 && PlayerPrefs.GetInt("Elements") >= 5)
        {
            Initiate.Fade(scene, Color.black, 10f);
        }
        else
        {
            objectWithButton.SetActive(false);
        }
    }
}
