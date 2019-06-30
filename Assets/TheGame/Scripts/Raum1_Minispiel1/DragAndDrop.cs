﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    /// <summary>
    /// the gameObject follows the mouse
    /// </summary>
    private void OnMouseDrag()
    {
        Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
        transform.position = newPosition;
    }
}