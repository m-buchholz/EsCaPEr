using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    // answer 1 is right
    private string singleQuest, answer1, answer2, answer3;

    // all quests in a 2-dimensional array
    // quest[0][0] = Quest 0 - Question
    // quest[0][1] = Quest 0 - Answer 1
    // quest[0][2] = Quest 0 - Answer 2
    // quest[0][3] = Quest 0 - Answer 3
    private string[][] quests;

    private int[] alreadyAsked;

    private int questionCounter;
    public GameObject pictureQuestionCanvas;
    public SpriteRenderer questionSprite;
    public Text questionNumber, textQuestion, pictureQuestion;
    public Button answerButton1, answerButton2, answerButton3;
    private Button confirmButton;
    private int random;

    void Start()
    {
        // setup
        questionCounter = 1;

        // include Button
        answerButton1.onClick.AddListener(delegate { setAnswer(answerButton1); });
        answerButton2.onClick.AddListener(delegate { setAnswer(answerButton2); });
        answerButton3.onClick.AddListener(delegate { setAnswer(answerButton3); });
        confirmButton = GetComponent<Button>();
        confirmButton.interactable = false;
        confirmButton.onClick.AddListener(proofAnswer);

        initializeQuests();

        setText(quests[19]);
        
    }

    private void initializeQuests()
    {
        quests = new string[21][];

        for (int i = 0; i <= 20; i++)
        {
            // split Quests in format Type/Question/RightAnswer/Answer2/Answer3 to Array containing seperate strings
            // Type: Q for Text Question, P for Picture Question
            quests[i] = PlayerPrefs.GetString("Q" + i).Split('/'); ;
        }
        Debug.Log("Letzte Frage: " + quests[20][0] + " mit Antwort 1: " + quests[20][1] + " und Antwort 2: " + quests[20][2] + " und Antwort 3: " + quests[20][3]);
    }

    private void setText(string[] quest)
    {
        questionNumber.text = "Frage " + questionCounter;
        Debug.Log("Frage: " + quest[0] + " mit Antwort 1: " + quest[1] + " und Antwort 2: " + quest[2] + " und Antwort 3: " + quest[3] + " wurde gesetzt.");
        if (quest[0] == "T")
        {
            // if text question
            pictureQuestionCanvas.SetActive(false);
            textQuestion.text = quest[1];
            textQuestion.enabled = true;
        }
        else
        {
            // if picture question
            textQuestion.enabled = false;
            pictureQuestion.text = quest[1];
            questionSprite.sprite = Resources.Load<Sprite>("Images/Utensils/" + quest[0]);
            pictureQuestionCanvas.SetActive(true);
        }
        answerButton1.GetComponentInChildren<Text>().text = quest[2];
        answerButton2.GetComponentInChildren<Text>().text = quest[3];
        answerButton3.GetComponentInChildren<Text>().text = quest[4];
    }

    private void setAnswer(Button pressed)
    {
        confirmButton.interactable = true;
        // todo
        questionCounter++;
    }

    private void proofAnswer()
    {
        // todo
    }

    private int getRandom()
    {
        return 0; //Random.Range(0, 20);
    }
}
