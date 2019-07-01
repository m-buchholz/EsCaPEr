using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SmokingFox : MonoBehaviour
{
    public Sprite smokingFox, smokingFoxTalking;
    public GameObject fox;
    public Text foxText;
    private Button button;
    private string foxSay;
    private string tip;

    void Start()
    {
        // hide smokingFox tips Overlay
        fox.SetActive(false);

        // include Button
        button = GetComponent<Button>();
        button.onClick.AddListener(openFox);

        getTip();

        if (PlayerPrefs.GetInt(tip) == 0)
        {
            changeFoxImage(smokingFoxTalking);
        }
        foxSay = PlayerPrefs.GetString(tip+"_T");

        if (PlayerPrefs.GetInt(tip) == 0) GetComponent<Animator>().SetBool("Blink", true);
        if (PlayerPrefs.GetInt(tip) == 1) GetComponent<Animator>().SetBool("Blink", false);
    }

    private void openFox()
    {
        foxText.text = foxSay;
        fox.SetActive(true);
        changeFoxImage(smokingFox);

        // get tip
        getTip();

        PlayerPrefs.SetInt(tip, 1);
        GetComponent<Animator>().SetBool("Blink", false);
    }

    private void changeFoxImage(Sprite image)
    {
        GetComponent<Image>().sprite = image;
        if (PlayerPrefs.GetInt(tip) == 0) GetComponent<Animator>().SetBool("Blink", true);
        if (PlayerPrefs.GetInt(tip) == 1) GetComponent<Animator>().SetBool("Blink", false);
    }

    private void getTip()
    {
        // switch tip in relation to active scene
        switch (SceneManager.GetActiveScene().name)
        {
            case "Foyer_Exit":
                tip = "F_E";
                break;
            case "Foyer_Rooms":
                tip = "F_R";
                break;
            case "Exit":
                tip = "E";
                break;
            case "Room1":
                tip = "R1";
                break;
            case "Room1_Minigame1":
                tip = "R1M1";
                break;
            case "Room1_Minigame2":
                tip = "R1M2";
                break;
            case "Room1_Minigame3":
                tip = "R1M3";
                break;
            case "Room2":
                tip = "R2";
                break;
            case "Room2_Minigame1":
                tip = "R2M1";
                break;
            case "Room2_Minigame2":
                tip = "R2M2";
                break;
            case "Room2_Minigame3":
                tip = "R2M3";
                break;
            case "Room2_Minigame4":
                tip = "R2M4";
                break;
            case "Room3":
                tip = "R3";
                break;
            case "Room3_Minigame1":
                tip = "R3M1";
                break;
            case "Room3_Minigame2":
                tip = "R3M2";
                break;
            default:
                tip = "Fail";
                break;
        }
    }
}
