using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControllerForAssignment : MonoBehaviour
{
    private bool correct = false;
    public GameObject box;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == box.tag)
            {
                transform.position = collision.gameObject.transform.position;
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
}
