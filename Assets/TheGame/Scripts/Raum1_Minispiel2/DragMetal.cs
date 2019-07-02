using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class DragMetal : MonoBehaviour
{

public int metaltype;
public GameObject ofen;

    private void OnMouseDrag()
    {
        if(ofen.GetComponent<CheckMetal>().metaltype < 1)
        {
        Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
        transform.position = newPosition;
        }
    }
    
   
    
    
}
