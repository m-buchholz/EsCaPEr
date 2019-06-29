using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControllerForEquation : MonoBehaviour
{
    private bool correct = false;
    private bool assign = false;
    public GameObject box;
    public int value;

    /// <summary>
    /// Catch the colliding gameObject
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("AssignmentBox"))
            {
            Debug.Log("Collision!");

            if (collision.bounds.Contains(transform.position))
            {
                assign = true;
                transform.position = collision.transform.position;

            }

            if (collision.gameObject.GetComponent<AssignBoxValue>().value == this.value) 
                correct = true;
        }
        else
        {

        }
    }

    /// <summary>
    /// return a boolean
    /// </summary>
    /// <returns></returns>
    public bool isCorrect()
    {
        return correct;
    }

    /// <summary>
    /// return a boolean
    /// </summary>
    /// <returns></returns>
    public bool isAssign()
    {
        return assign;
    }

    /// <summary>
    /// reset the booleans on exit the collision
    /// </summary>
    /// <param name="collision"></param>
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
