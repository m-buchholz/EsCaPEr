using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabs : MonoBehaviour
{
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

    List<GameObject> utensils = new List<GameObject>();


    public List<GameObject> PrefabsUtensils()
    {
        foreach(string name in UtensilList)
        {
            utensils.Add(GeneratePrefab(name));

        }
        return utensils;
    }

    public GameObject GeneratePrefab(string name)
    {
        GameObject utensil = new GameObject();
        GameObject check = new GameObject();
        GameObject cross = new GameObject();
        GameObject spriteObject = new GameObject();

        setSettingToSpriteObject(spriteObject, name);
        spriteObject.transform.SetParent(utensil.transform);
        utensil.name = name;





        cross.AddComponent<SpriteRenderer>();
        cross.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Icons/Room1_Minigame1/cross");
        cross.GetComponent<SpriteRenderer>().sortingOrder = 3;
        cross.transform.SetParent(utensil.transform);
        var bounds = cross.GetComponent<SpriteRenderer>().sprite.bounds;
        var factor = 3 / bounds.size.y;
        cross.transform.localScale = new Vector3(factor, factor, factor);

        check.AddComponent<SpriteRenderer>();
        check.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Icons/Room1_Minigame1/check");
        check.GetComponent<SpriteRenderer>().sortingOrder = 3;
        check.transform.SetParent(utensil.transform);

        spriteObject.GetComponent<FadeIn>().FadeOutSymbol(1, utensil);
        spriteObject.GetComponent<FadeIn>().FadeOutSymbol(2, utensil);


        return utensil;
    }

    private void setSettingToSpriteObject(GameObject spriteObject, string name)
    {
        spriteObject.AddComponent<SpriteRenderer>();
        spriteObject.AddComponent<BoxCollider2D>();
        spriteObject.AddComponent<Rigidbody2D>();
        spriteObject.AddComponent<FadeIn>();
        spriteObject.AddComponent<JumpBackToAnAnchor>();
        spriteObject.AddComponent<DragAndDrop>();
        spriteObject.AddComponent<CollisionControllerForAssignment>();
        spriteObject.AddComponent<JumpWhenMouseHoverOver>();
        spriteObject.name = name;
        spriteObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Images/Utensils/" + name);
        spriteObject.transform.Translate(0.0f, 0.0f, 0.0f);
        spriteObject.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
        spriteObject.GetComponent<SpriteRenderer>().sortingOrder = 2;

        var bounds = spriteObject.GetComponent<SpriteRenderer>().sprite.bounds;
        if (bounds.size.y > bounds.size.x)
        {
            var factor = 3 / bounds.size.y;
            spriteObject.transform.localScale = new Vector3(factor, factor, factor);
        }
        else
        {
            var factor = 3 / bounds.size.x;
            spriteObject.transform.localScale = new Vector3(factor, factor, factor);
        }


        spriteObject.GetComponent<Rigidbody2D>().freezeRotation = true;
        spriteObject.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;

        spriteObject.GetComponent<BoxCollider2D>().size = spriteObject.GetComponent<SpriteRenderer>().size;
        

    }

}
