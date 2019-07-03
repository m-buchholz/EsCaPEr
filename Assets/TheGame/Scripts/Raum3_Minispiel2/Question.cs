using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// implements the game logic of a quiz
/// </summary>

public class Question : MonoBehaviour
{
    // all quests in a 2-dimensional array
    // quest[0][0] = Quest 0 - Question
    // quest[0][1] = Quest 0 - Answer 1
    // quest[0][2] = Quest 0 - Answer 2
    // quest[0][3] = Quest 0 - Answer 3
    private string[][] quests, rQuests;

    private int[] alreadyAsked;

    private int points;
    private int mistakes;
    private int questionCounter;
    // Button 1/2/3
    private int pressed;

    // Settings
    public int questionAmount = 21;
    public int maxQuestions = 16;
    public int maxMistakes = 3;

    // Objects
    public GameObject pictureQuestionCanvas;
    public SpriteRenderer questionSprite;
    public Text questionNumberText, textQuestionText, pictureQuestionText, pointsText;
    public Button answerButton1, answerButton2, answerButton3;
    public GameObject professor;
    public Text professorText;
    public Button profResume;

    private Button confirmButton;
    private int random;

    void Start()
    {
        // setup
        questionCounter = 0;
        points = 0;
        mistakes = 0;
        answerButton1.interactable = true;
        answerButton2.interactable = true;
        answerButton3.interactable = true;

        // include Button
        answerButton1.onClick.AddListener(delegate {
            // pressed = 2, because of Button 1 = Answer 1 = quests[i][2]
            pressed = 2;
            setAnswer(answerButton1); });
        answerButton2.onClick.AddListener(delegate {
            pressed = 3;
            setAnswer(answerButton2); });
        answerButton3.onClick.AddListener(delegate {
            pressed = 4;
            setAnswer(answerButton3); });
        confirmButton = GetComponent<Button>();
        confirmButton.interactable = false;
        confirmButton.onClick.AddListener(proofAnswer);

        initializeQuests();
        shuffleQuests();

        setText(rQuests[questionCounter]);
    }

    private void initializeQuests()
    {
        // read quests in PlayerPrefs and split in an 2-dimensional array
        quests = new string[questionAmount][];
        rQuests = new string[questionAmount][];

        for (int i = 0; i <= quests.Length-1; i++)
        {
            // split Quests in format Type/Question/RightAnswer/Answer2/Answer3 to Array containing seperate strings
            // Type: Q for Text Question, P for Picture Question
            quests[i] = PlayerPrefs.GetString("Q" + i).Split('/');
            rQuests[i] = PlayerPrefs.GetString("Q" + i).Split('/');
        }
    }

    private void setText(string[] quest)
    {
        // set all texts or/and pictures
        questionNumberText.text = "Frage " + (questionCounter+1);
        if (quest[0] == "T")
        {
            // if text question
            pictureQuestionCanvas.SetActive(false);
            textQuestionText.text = quest[1];
            textQuestionText.enabled = true;
        }
        else
        {
            // if picture question
            textQuestionText.enabled = false;
            pictureQuestionText.text = quest[1];
            if (Resources.Load<Sprite>("Images/Utensils/" + quest[0]) != null)
                questionSprite.sprite = Resources.Load<Sprite>("Images/Utensils/" + quest[0]);
            else questionSprite.sprite = Resources.Load<Sprite>("Images/Symbols/" + quest[0]);
            pictureQuestionCanvas.SetActive(true);
        }
        answerButton1.GetComponentInChildren<Text>().text = quest[2];
        answerButton2.GetComponentInChildren<Text>().text = quest[3];
        answerButton3.GetComponentInChildren<Text>().text = quest[4];
        pointsText.text = "Punkte: " + points;
    }

    private void setAnswer(Button button)
    {
        // reset all buttons to color white
        paintButtonsWhite();

        confirmButton.interactable = true;

        // paint pressed button
        Color col = button.GetComponent<Image>().color;
        col.a = 0.60f;
        button.GetComponent<Image>().color = col;
    }

    private void proofAnswer()
    {
        // reset all buttons to color white
        paintButtonsWhite();

        // calculate points and mistakes
        if (rQuests[questionCounter][pressed] == quests[questionCounter][2])
        {
            points++;
        }
        else
        {
            mistakes++;
        }

        // reset pressed button and confirm button
        pressed = 1;
        confirmButton.interactable = false;

        // calculate question counter
        questionCounter++;

        // if maxQuestions reached -> finish()
        if (questionCounter+1 <= maxQuestions)
        {
            // set new quest, answers, etc.
            setText(rQuests[questionCounter]);
        }
        else finish();
    }

    // Fisher-Yates-Shuffle
    private void shuffleQuests()
    {
        // shuffle answers in rQuests[i][2] to rQuests[i][4]
        for (int i = 0; i <= rQuests.Length-1; i++)
        {
            for (int j = 2; j <= 4; j++)
            {
                int r = Random.Range(j, 5);
                string tmp = rQuests[i][j];
                rQuests[i][j] = rQuests[i][r];
                rQuests[i][r] = tmp;
            }
        }

        // shuffle quests (with correct answer at quests[i][2]) and rQuests (with randomized answers)
        for (int i = 0; i <= rQuests.Length-1; i++)
        {
            int r = Random.Range(i, rQuests.Length);
            string[] tmp1 = quests[i];
            quests[i] = quests[r];
            quests[r] = tmp1;
            string[] tmp2 = rQuests[i];
            rQuests[i] = rQuests[r];
            rQuests[r] = tmp2;
        }
    }

    private void paintButtonsWhite()
    {
        answerButton1.GetComponent<Image>().color = Color.white;
        answerButton2.GetComponent<Image>().color = Color.white;
        answerButton3.GetComponent<Image>().color = Color.white;
    }

    private void finish()
    {
        answerButton1.interactable = false;
        answerButton2.interactable = false;
        answerButton3.interactable = false;

        // if win
        if (mistakes <= maxMistakes)
        {
            professorText.text = PlayerPrefs.GetString("R3M2_W");
            PlayerPrefs.SetInt("Room3_Minigame2", 1);
            PlayerPrefs.SetInt("Elements", (PlayerPrefs.GetInt("Elements") + 1));
            PlayerPrefs.SetString("ElementsInventory", PlayerPrefs.GetString("ElementsInventory") + "54-Xe" + ",");
        }
        // else lose
        else professorText.text = PlayerPrefs.GetString("R3M2_L");
        professor.SetActive(true);
        profResume.onClick.AddListener(fadeOut);
    }

    private void fadeOut()
    {
        Initiate.Fade("Room3", Color.black, 10f);
    }
}