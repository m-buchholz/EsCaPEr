using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CheckForGameCompletion : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
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

    public void ChangeImage()
    {


        if(utensil1.GetComponent<CollisionControllerForAssignment>().isCorrect() == false ||
            utensil2.GetComponent<CollisionControllerForAssignment>().isCorrect() == false ||
            utensil3.GetComponent<CollisionControllerForAssignment>().isCorrect() == false ||
            utensil4.GetComponent<CollisionControllerForAssignment>().isCorrect() == false ||
            utensil5.GetComponent<CollisionControllerForAssignment>().isCorrect() == false)
        {
            GetComponent<Image>().sprite = image1;
            StartCoroutine(Timer());
            GetComponent<Image>().sprite = image2;

        }
        
    }


    IEnumerator Timer()
    {
        print(Time.time);
        yield return new WaitForSeconds(5000);
        print(Time.time);
    }
}
