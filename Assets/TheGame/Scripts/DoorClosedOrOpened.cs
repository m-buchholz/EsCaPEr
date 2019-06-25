using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorClosedOrOpened : MonoBehaviour
{
    private Button button;
    public GameObject foxOverlay;
    public Text foxText;
    public string scene;

    void Start()
    {
        // include Button
        button = GetComponent<Button>();
        button.onClick.AddListener(openDoor);
    }

    private void openDoor()
    {
        if (PlayerPrefs.GetInt(scene) == 0)
        {
            foxText.text = PlayerPrefs.GetString("Door_locked");
            foxOverlay.SetActive(true);
        }
        else
        {
            Initiate.Fade(scene, Color.black, 10f);
        }
    }
}
