using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBackToAnAnchor : MonoBehaviour
{
    public GameObject anchor;

    /// <summary>
    /// Set the position of the gameObject to the position of an given anchor
    /// </summary>
    private void OnMouseUp()
    {
        if (GetComponent<CollisionControllerForAssignment>().isAssign() == false)
        {
            transform.position = anchor.transform.position;
        }
    }
}
