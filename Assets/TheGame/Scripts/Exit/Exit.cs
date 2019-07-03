using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public GameObject fox;
    public Text foxText;
    public Button continueToEnd, pseLeft, pseRight;
    public Sprite pseLeftFull, pseRightFull;

    private Button button;

    void Start()
    {
        // include Button
        button = GetComponent<Button>();
        button.onClick.AddListener(openFox);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (PlayerPrefs.GetInt("Elements") == 6 && foxText.text == PlayerPrefs.GetString("Exit_O"))
            {
                finish();
            }
        }
    }

    private void openFox()
    {
        if (PlayerPrefs.GetInt("Exit") == 0)
        {
            if (PlayerPrefs.GetInt("Elements") == 6)
            {
                foxText.text = PlayerPrefs.GetString("Exit_O");
                continueToEnd.onClick.AddListener(finish);
            }
            else
            {
                foxText.text = PlayerPrefs.GetString("Exit_C");
            }
            fox.SetActive(true);
        }
        else
        {
            Initiate.Fade("Exit", Color.black, 10f);
        }
    }

    private void finish()
    {
        GameObject.Find("ElementsHUD").GetComponent<Animator>().SetBool("FadeOut", true);
        // unlocks in ExitExplosions.cs
    }
}
