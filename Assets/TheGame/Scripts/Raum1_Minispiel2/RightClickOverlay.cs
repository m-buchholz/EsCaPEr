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
        over.SetActive (true);       
    }
    
    void OnMouseExit()
    {
        over.SetActive (false);
    }
}