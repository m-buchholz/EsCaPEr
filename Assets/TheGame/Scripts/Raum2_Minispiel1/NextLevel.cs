using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private Button button;
    ElementO elementO;

    // Use this for initialization
    void Start()
    {
        elementO = GameObject.Find("element_o").GetComponent<ElementO>();

        button = GetComponent<Button>();
        button.onClick.AddListener(nextLevel);

        Debug.Log(elementO.isCollected());
    }

    void nextLevel()
    {
        if (elementO.isCollected())
        {
            Initiate.Fade("Room2_Minigame2", Color.black, 10f);
        }

    }
}
