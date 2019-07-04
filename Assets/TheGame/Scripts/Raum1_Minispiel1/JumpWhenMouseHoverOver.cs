using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpWhenMouseHoverOver : MonoBehaviour
{
    public float jump = 0.1f;
    private bool col = false;

    /// <summary>
    /// Set a boolean true in an collision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            col = true;
        }
    }

    /// <summary>
    /// set a boolean false on exit a collision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            col = false;
        }
    }

    /// <summary>
    /// Transform the y-coordinate of an gameObject when the mouse hover over
    /// </summary>
    private void OnMouseEnter()
    {
        if (col == true)
        {
            if (Input.GetMouseButton(0) != true && GetComponent<CollisionControllerForAssignment>().isAssign() == false)
            {
                // Debug.Log("gedrückt");
                transform.position = new Vector3(transform.position.x, transform.position.y + jump, transform.position.z);
            }
        }
    }
}
