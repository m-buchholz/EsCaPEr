using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBackToAnAnchor : MonoBehaviour
{
    public GameObject anchor;
    private void OnMouseUp()
    {
        if (GetComponent<CollisionControllerForAssignment>().isAssign() == false)
        {
            transform.position = anchor.transform.position;
        }
    }
}
