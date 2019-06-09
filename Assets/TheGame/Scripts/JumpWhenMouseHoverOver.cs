using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpWhenMouseHoverOver : MonoBehaviour
{
    public float jump = 0.1f;
    private bool col = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            col = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            col = false;
        }
    }
    private void OnMouseEnter()
    {
        if (col == true)
        {
            if (Input.GetMouseButton(0) != true && GetComponent<CollisionControllerForAssignment>().isAssign() == false)
            {
                Debug.Log("gedrückt");
                transform.position = new Vector3(transform.position.x, transform.position.y + jump, transform.position.z);
            }
        }
    }
}
