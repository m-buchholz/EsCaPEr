using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControllerForAssignment : MonoBehaviour
{
    private bool correct = false;
    private bool assign = false;
    public GameObject box;
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == box.tag)
            {
            Debug.Log("Collision!");

            if (collision.bounds.Contains(transform.position))
            {
                assign = true;
                transform.position = collision.transform.position + new Vector3(0, 2.2f, 0);

            }

            if (collision.gameObject.Equals(box)) 
                correct = true;
        }
        else
        {

        }
    }

    public bool isCorrect()
    {
        return correct;
    }

    public bool isAssign()
    {
        return assign;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            assign = false;
            correct = false;

        Debug.Log("end Collision");
    }
    private void Update()
    {
        Debug.Log("Correct = " + correct + " Assign = " + assign  + " Name: "+ name);

    }
}
