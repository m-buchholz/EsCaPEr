using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    private Button button;
    public GameObject fox;
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
            if (PlayerPrefs.GetInt(scene + "-Key") == 0)
            {
                fox.GetComponentInChildren<Text>().text = PlayerPrefs.GetString("Door_locked");
            }
            else
            {
                fox.GetComponentInChildren<Text>().text = PlayerPrefs.GetString("Door_unlock");
                PlayerPrefs.SetInt(scene, 1);
            }
            fox.SetActive(true);
        }
        else
        {
            Initiate.Fade(scene, Color.black, 10f);
        }
    }
}
