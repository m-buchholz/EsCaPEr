using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ClickOverlay : MonoBehaviour
{
    public GameObject over;
    
    void Start ()
    {
        over.SetActive (false);
    }
    
    
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
            {
                over.SetActive (true);
            }
            
        if (Input.GetMouseButtonUp(0)|| Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2))
            {
                over.SetActive (false);
            }
             
            
    }   
}