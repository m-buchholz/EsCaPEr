using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionControllerForNeutralization : MonoBehaviour
{
    public Sprite reagenzglasFett;
    public Sprite reagenzglas_ph07;

    GameObject glass_h2so4;
    GameObject glass_naoh;

    GameObject key;

    void Start()
    {
        glass_h2so4 = GameObject.Find("glass_h2so4");
        glass_naoh = GameObject.Find("glass_naoh");

        key = GameObject.Find("raum2_Key");

        key.GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
    }

    /// <summary>
    /// Catch the colliding gameObject
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject == GameObject.Find("glass_h2so4"))
        {
            Debug.Log("Collision!");

            glass_naoh.GetComponent<SpriteRenderer>().sprite = reagenzglasFett;
            glass_naoh.GetComponent<RectTransform>().localScale = new Vector3(65, 65, 65);

            glass_h2so4.GetComponent<SpriteRenderer>().sprite = reagenzglas_ph07;

            key.GetComponent<Image>().color = new Color(1, 1, 1, 1);

            if (key.GetComponent<Key>().getNeutralized() == false)
                key.GetComponent<Key>().setNeutralized(true);
        }
        else
        {

        }
    }
}