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

    void Start()
    {
        // hide smokingFox tips Overlay
        fox.SetActive(false);

        // include Button
        button = GetComponent<Button>();
        button.onClick.AddListener(openFox);

        // switch tip in relation to active scene
        switch (SceneManager.GetActiveScene().name)
        {
            case "Foyer_Exit":
                if (PlayerPrefs.GetInt("F_E") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("F_E_T");
                    PlayerPrefs.SetInt("F_E", 1);
                }
                break;
            case "Foyer_Rooms":
                if (PlayerPrefs.GetInt("F_R") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("F_R_T");
                    PlayerPrefs.SetInt("F_R", 1);
                }
                break;
            case "Room1":
                if (PlayerPrefs.GetInt("R1") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R1_T");
                    PlayerPrefs.SetInt("R1", 1);
                }
                break;
            case "Room1_Minigame1":
                if (PlayerPrefs.GetInt("R1M1") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R1M1_T");
                    PlayerPrefs.SetInt("R1M1", 1);
                }
                break;
            case "Room1_Minigame2":
                if (PlayerPrefs.GetInt("R1M2") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R1M2_T");
                    PlayerPrefs.SetInt("R1M2", 1);
                }
                break;
            case "Room1_Minigame3":
                if (PlayerPrefs.GetInt("R1M3") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R1M3_T");
                    PlayerPrefs.SetInt("R1M3", 1);
                }
                break;
            case "Room2":
                if (PlayerPrefs.GetInt("R2") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R2_T");
                    PlayerPrefs.SetInt("R2", 1);
                }
                break;
            case "Room2_Minigame1":
                if (PlayerPrefs.GetInt("R2M1") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R2M1_T");
                    PlayerPrefs.SetInt("R2M1", 1);
                }
                break;
            case "Room2_Minigame2":
                if (PlayerPrefs.GetInt("R2M2") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R2M2_T");
                    PlayerPrefs.SetInt("R2M2", 1);
                }
                break;
            case "Room2_Minigame3":
                if (PlayerPrefs.GetInt("R2M3") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R2M3_T");
                    PlayerPrefs.SetInt("R2M3", 1);
                }
                break;
            case "Room3":
                if (PlayerPrefs.GetInt("R3") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R3_T");
                    PlayerPrefs.SetInt("R3", 1);
                }
                break;
            case "Room3_Minigame1":
                if (PlayerPrefs.GetInt("R3M1") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R3M1_T");
                    PlayerPrefs.SetInt("R3M1", 1);
                }
                break;
            case "Room3_Minigame2":
                if (PlayerPrefs.GetInt("R3M2") == 0)
                {
                    changeFoxImage(smokingFoxTalking);
                    foxSay = PlayerPrefs.GetString("R3M2_T");
                    PlayerPrefs.SetInt("R3M2", 1);
                }
                break;
            default:
                break;
        }
    }

    private void openFox()
    {
        fox.SetActive(true);
        foxText.text = foxSay;
        changeFoxImage(smokingFox);
    }

    private void changeFoxImage(Sprite image)
    {
        GetComponent<Image>().sprite = image;
    }
}
