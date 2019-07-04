using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControllerForAssignment : MonoBehaviour
{
    private bool correct = false;
    private bool assign = false;
    public GameObject box;

    /// <summary>
    /// Catch the colliding gameObject
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == box.tag)
            {
            // Debug.Log("Collision!");

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

        // Debug.Log("end Collision");
    }
    private void Update()
    {
        // Debug.Log("Correct = " + correct + " Assign = " + assign  + " Name: "+ name);

    }


}
