using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class RightClickOverlay : MonoBehaviour
{
    public GameObject over;
    
    void Start ()
    {
        over.SetActive (false);
    }
    
    
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
            {
                over.SetActive (true);
            }
            
        if (Input.GetMouseButtonUp(1))
            {
                over.SetActive (false);
            }
             
            
    }
}