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
    };

    List<Vector2> UtensilPos = new List<Vector2>()
    {
        new Vector2(4, -3),
        new Vector2(-8, -3),
        new Vector2(8, -3),
        new Vector2(0, -3),
        new Vector2(-4, -3),
        
        
        
    };
    int n = 0;


    // Start is called before the first frame update
    void Start()
    {
        GenerateObj("Messzylinder");
        GenerateObj("ErlenMyer");
        GenerateObj("Reagenzglas");
        GenerateObj("Bunsenbrenner");
        GenerateObj("Stopfen");
    }

    private void GenerateObj(string uten)
    {
        int i = Random.Range(0, BoxPos.Count);
        GameObject spawn = (GameObject)Instantiate(Resources.Load("Prefabs/Spawn"));
        GameObject utensil = (GameObject)Instantiate(Resources.Load("Prefabs/" + uten));

        GameObject boxObject = GenerateBox("Box" + uten, BoxPos[i]);
        GameObject text = (GameObject)Instantiate(Resources.Load("Prefabs/UtensilText"));
        GameObject parentOfText = GameObject.Find("Text");
        GameObject check = GameObject.Find("Completion Button");

        text.transform.parent = parentOfText.transform;
        text.transform.position = new Vector2(boxObject.transform.position.x, boxObject.transform.position.y - 1);
        text.transform.localScale = new Vector3(1, 1, 1);
        text.transform.GetComponent<Text>().text = utensil.name;
        utensil.transform.position = UtensilPos[i];
        spawn.transform.position = UtensilPos[i];

        utensil.transform.GetChild(1).GetComponent<JumpBackToAnAnchor>().anchor = spawn;
        utensil.transform.GetChild(1).GetComponent<CollisionControllerForAssignment>().box = boxObject;
        check.GetComponent<CheckForGameCompletion>().utensils[n] = utensil.transform.GetChild(1).gameObject;

        n++;
        BoxPos.RemoveAt(i);
        UtensilPos.RemoveAt(i);
    }

    private GameObject GenerateBox(string uten, Vector2 pos)
    {
        GameObject utensil = (GameObject)Instantiate(Resources.Load("Prefabs/" + uten));
        utensil.transform.position = pos;
        return utensil;
    }


}
