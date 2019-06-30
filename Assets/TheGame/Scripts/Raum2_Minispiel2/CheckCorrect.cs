using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckCorrect : MonoBehaviour
{
    GameObject number1;
    GameObject number2;
    GameObject number3;
    GameObject number4;

    // Use this for initialization
    void Start()
    {
        number1 = GameObject.Find("number1");
        number2 = GameObject.Find("number2");
        number3 = GameObject.Find("number3");
        number4 = GameObject.Find("number4");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckForCompletion()
    {
        if (number1.GetComponent<CollisionControllerForEquation>().isCorrect() && 
            number2.GetComponent<CollisionControllerForEquation>().isCorrect() &&
        number3.GetComponent<CollisionControllerForEquation>().isCorrect() &&
        number4.GetComponent<CollisionControllerForEquation>().isCorrect())
        {
            SceneManager.LoadScene("Room2_Minigame3", LoadSceneMode.Single);
        }
    }
}
