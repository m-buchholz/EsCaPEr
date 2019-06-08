using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControllerForAssignment : MonoBehaviour
{
    private bool correct = false;
    private bool assign = false;
    public GameObject box;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == box.tag)
            {
            Debug.Log("Collision!");
                transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
                assign = true;
            if (collision.gameObject.Equals(box))
            {
                correct = true;
            }
                
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

    public void OnCollisionExit2D(Collision2D collision)
    {
        assign = false;
        correct = false;
    }
    private void Update()
    {
        Debug.Log("Correct = " + correct + " Assign = " + assign  + " Name: "+ name);
    }
}
