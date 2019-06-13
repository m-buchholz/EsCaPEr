using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CheckForGameCompletion : MonoBehaviour
{
    public GameObject[] utensils = new GameObject[5];

    /// <summary>
    /// Checked if the GameObject are assigned correctly
    /// </summary>
    public void CheckForCompletion()
    {
        if( utensils[0].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[1].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[2].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[3].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[4].GetComponent<CollisionControllerForAssignment>().isCorrect() == true)
        {
            SceneManager.LoadScene("Room1", LoadSceneMode.Single);
        }
        int i = 0;
        while(i < 5)
        {
            if (utensils[i].gameObject.GetComponent<CollisionControllerForAssignment>().isAssign() == true)
            {
                GameObject utensil = utensils[i];
                if (utensil.GetComponent<FadeIn>().isActiveAndEnabled == true)
                {
                    utensil.GetComponent<FadeIn>().Fade();
                }
                utensil.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
                utensil.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
                utensil.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            }
            i++;
        }
    }

}
