using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    // answer 1 is right
    private string quest, answer1, answer2, answer3;
    private string[] allQuests;
    public Text questionNumber, textQuestion, pictureQuestion;
    public Image questionImage;
    public Button answerButton1, answerButton2, answerButton3, confirmButton;

    void Start()
    {
        // include Button
        answerButton1.onClick.AddListener(delegate { setAnswer(answerButton1); });
        answerButton2.onClick.AddListener(delegate { setAnswer(answerButton2); });
        answerButton3.onClick.AddListener(delegate { setAnswer(answerButton3); });
        confirmButton.interactable = false;
        confirmButton.onClick.AddListener(proofAnswer);

        for (int i = 0; i<=20; i++)
        {
            allQuests[i] = PlayerPrefs.GetString("Q" + i);
        }
    }

    private void setAnswer(Button pressed)
    {
        confirmButton.interactable = true;
    }

    private void proofAnswer()
    {

    }

    // split Question in Format Question/RightAnswer/Answer2/Answer3 to Array containing seperate strings
    private string[] splitQuest(string rawQuest)
    {
        return rawQuest.Split('/');
    }
}
