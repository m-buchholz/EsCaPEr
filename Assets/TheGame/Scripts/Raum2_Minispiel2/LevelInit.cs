using UnityEngine;
using System.Collections;

public class LevelInit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject number1 = GameObject.Find("number1");
        GameObject number2 = GameObject.Find("number2");
        GameObject number3 = GameObject.Find("number3");
        GameObject number4 = GameObject.Find("number4");

        number1.GetComponent<Rigidbody2D>().freezeRotation = true;
        number2.GetComponent<Rigidbody2D>().freezeRotation = true;
        number3.GetComponent<Rigidbody2D>().freezeRotation = true;
        number4.GetComponent<Rigidbody2D>().freezeRotation = true;

        number1.GetComponent<CollisionControllerForEquation>().value = 1;
        number2.GetComponent<CollisionControllerForEquation>().value = 2;
        number3.GetComponent<CollisionControllerForEquation>().value = 1;
        number4.GetComponent<CollisionControllerForEquation>().value = 2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
