using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Moulding : MonoBehaviour
{
    Animator m_Animator;
    public GameObject ofenknopf;
    public GameObject ofen;
    public GameObject key;
    float time = 1.0f;
    
    void Start ()
    {
         m_Animator = GetComponent<Animator>();
         key.SetActive (false);         
    }
    
    
    
    void Update()
    {
        if (ofenknopf.GetComponent<ClickOverlayOven>().active == true && ofen.GetComponent<CheckMetal>().metalinoven == true)
            {
               m_Animator.SetBool("ButtonIsPressed", true);
               m_Animator.SetBool("KeyTaken", false);  
               
               if(time >= 0)
               {
               time -= Time.deltaTime;
               return;
               }
               else 
               {
               key.SetActive (true);
               time = 1.0f;
               }
               
               
               
               
            }
            if (ofenknopf.GetComponent<ClickOverlayOven>().active == false )
            {
               m_Animator.SetBool("ButtonIsPressed", false);
               m_Animator.SetBool("KeyTaken", true); 
            }
            
             
            
    }
}