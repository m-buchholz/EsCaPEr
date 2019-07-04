using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoGenUtensils : MonoBehaviour
{
    
    List<Vector2> BoxPos = new List<Vector2>()
    {
        new Vector2(-8, 0.5f),
        new Vector2(-4, 0.5f),
        new Vector2(0, 0.5f),
        new Vector2(4, 0.5f),
        new Vector2(8, 0.5f),
        new Vector2(-8 + 28, 0.5f),
        new Vector2(-4 + 28, 0.5f),
        new Vector2(0 + 28, 0.5f),
        new Vector2(4 + 28, 0.5f),
        new Vector2(8 + 28, 0.5f)
    };

    List<Vector2> UtensilPos = new List<Vector2>()
    {
        new Vector2(4, -3),
        new Vector2(-8, -3),
        new Vector2(8, -3),
        new Vector2(0, -3),
        new Vector2(-4, -3),
        new Vector2(4 + 28, -3),
        new Vector2(-8 + 28, -3),
        new Vector2(8 + 28, -3),
        new Vector2(0 + 28, -3),
        new Vector2(-4 + 28, -3)



    };

    List<string> UtensilList = new List<string>()
    {
        "Stopfen",
        "Messzylinder",
        "Erlenmeyerkolben",
        "Reagenzglas",
        "Bunsenbrenner",
        "Pipette",
        "Rundkolben",
        "Spatellöffel",
        "Stehkolben",
        "Thermometer"
    };
    int n = 0;


    void Start()
    {
        int i = 0;
        /*while(i < UtensilList.Count)
        {
            Debug.Log(" i = " + i);
            GenerateObj(UtensilList[i]);
            UtensilList.RemoveAt(i);
        }*/

        List<GameObject> utensils = GetComponent<prefabs>().PrefabsUtensils();

        foreach(GameObject utensil in utensils)
        {
            GenerateObj(utensil);
        }


    }

    private void GenerateObj(GameObject utensil)
    {
        int i = Random.Range(0, BoxPos.Count);
        GameObject spawn = (GameObject)Instantiate(Resources.Load("Prefabs/Room1_Minigame1/Spawn"));

        GameObject boxObject = GenerateBox(utensil.name, BoxPos[i]);
        GameObject text = (GameObject)Instantiate(Resources.Load("Prefabs/Room1_Minigame1/UtensilText"));
        GameObject parentOfText = GameObject.Find("Discription");
        GameObject check = GameObject.Find("Completion Button");

        text.transform.SetParent(parentOfText.transform);
        text.transform.position = new Vector2(boxObject.transform.position.x, boxObject.transform.position.y - 0.7f);
        text.transform.localScale = new Vector3(1, 1, 1);
        text.transform.GetComponent<Text>().text = utensil.name;
        utensil.transform.position = UtensilPos[i];
        spawn.transform.position = UtensilPos[i];

        utensil.transform.GetChild(0).GetComponent<JumpBackToAnAnchor>().anchor = spawn;
        utensil.transform.GetChild(0).GetComponent<CollisionControllerForAssignment>().box = boxObject;

        check.GetComponent<CheckForGameCompletion>().utensils[n] = utensil.transform.GetChild(0).gameObject;
        // Debug.Log("so sachen : " + check.GetComponent<CheckForGameCompletion>().utensils[0].GetComponent<CollisionControllerForAssignment>().isCorrect());
        n++;
        BoxPos.RemoveAt(i);
        UtensilPos.RemoveAt(i);
    }

    private GameObject GenerateBox(string uten, Vector2 pos)
    {
        GameObject utensil = (GameObject)Instantiate(Resources.Load("Prefabs/Room1_Minigame1/box"));
        // Debug.Log(utensil.name + "   " + uten);
        utensil.name = "box" + uten;
        utensil.transform.position = pos;
        return utensil;
    }


}
