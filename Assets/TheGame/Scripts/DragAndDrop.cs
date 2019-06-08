using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject anchor;
    public float jump = 0.1f;
    
    private void OnMouseDrag()
    {
       
        Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
        transform.position = newPosition;
    }

    private void OnMouseUp()
    {
        if(GetComponent<CollisionControllerForAssignment>().isAssign() == false)
        {
            transform.position = anchor.transform.position;
        }
    }

    private void OnMouseEnter()
    {
        if (Input.GetMouseButton(0) != true && GetComponent<CollisionControllerForAssignment>().isAssign() == false)
        {
            Debug.Log("gedrückt");
            transform.position = new Vector3(transform.position.x, anchor.transform.position.y + jump, transform.position.z);
        }
    }

}
