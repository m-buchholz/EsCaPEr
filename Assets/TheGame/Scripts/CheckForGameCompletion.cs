using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckForGameCompletion : MonoBehaviour
{
    public GameObject utensil1, utensil2, utensil3, utensil4, utensil5;
    public void CheckForCompletion()
    {
        if( utensil1.GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensil2.GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensil3.GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensil4.GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensil5.GetComponent<CollisionControllerForAssignment>().isCorrect() == true)
        {
            SceneManager.LoadScene("Room1", LoadSceneMode.Single);
        }
    }
}
