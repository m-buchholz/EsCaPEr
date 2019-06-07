using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControllerForAssignment : MonoBehaviour
{
    private bool correct = false;
    public GameObject collisionObject;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == collisionObject.name)
            {
                transform.position = collision.gameObject.transform.position;
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
}
