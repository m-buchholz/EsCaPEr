using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CheckForGameCompletion : MonoBehaviour
{
    public GameObject[] utensils = new GameObject[10];

    /// <summary>
    /// Checked if the GameObject are assigned correctly
    /// </summary>
    public void CheckForCompletion()
    {
        Sort();
        if( utensils[0].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[1].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[2].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[3].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[4].GetComponent<CollisionControllerForAssignment>().isCorrect() == true)
        {
            Invoke("Test", 2);
        }

        if (utensils[5].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[6].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[7].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[8].GetComponent<CollisionControllerForAssignment>().isCorrect() == true &&
            utensils[9].GetComponent<CollisionControllerForAssignment>().isCorrect() == true)
        {
            Invoke("CheckForFinish", 2);
        }

            int i = 0;
        while(i < utensils.Length)
        {
            if (utensils[i].gameObject.GetComponent<CollisionControllerForAssignment>().isAssign() == true)
            {
                GameObject utensil = utensils[i];
                if (utensil.GetComponent<FadeIn>().isActiveAndEnabled == true)
                {
                    utensil.GetComponent<FadeIn>().Fade();
                }
                utensil.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
                utensil.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                utensil.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            }
            i++;
        }
    }

    public void CheckForFinish()
    {
        PlayerPrefs.SetInt("Room1_Minigame1", 1);
        PlayerPrefs.SetInt("Elements", (PlayerPrefs.GetInt("Elements") + 1));
        PlayerPrefs.SetString("ElementsInventory", (PlayerPrefs.GetString("ElementsInventory") + "1-H,"));
        Initiate.Fade("Room1", Color.black, 10f);
    }

    private void Sort()
    {
        int i = 0;
        GameObject[] util = new GameObject[10];
        while(i < utensils.Length)
        {
            GameObject obj = utensils[i].transform.parent.gameObject;
            if(obj.transform.position.x == -8)
            {
                util[0] = obj.transform.GetChild(0).gameObject;
            }
            else if(obj.transform.position.x == -4)
            {
                util[1] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 0)
            {
                util[2] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 4)
            {
                util[3] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 8)
            {
                util[4] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 20)
            {
                util[5] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 24)
            {
                util[6] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 28)
            {
                util[7] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 32)
            {
                util[8] = obj.transform.GetChild(0).gameObject;
            }
            else if (obj.transform.position.x == 36)
            {
                util[9] = obj.transform.GetChild(0).gameObject;
            }
            i++;
        }
        utensils = util;

    }

    public void Test()
    {
        GetComponent<CameraMove>().check = true;
    }
}

