using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckMetal : MonoBehaviour
{
    public bool metalinoven;
    public int metaltype;
   
    public GameObject giessform;
    Animator animator;
    
    public Transform titan;
    public Transform platin;
    public Transform eisen;
    public Transform aluminium;
    public Transform nickel;
    
    public GameObject titanobj;
    public GameObject platinobj;
    public GameObject eisenobj;
    public GameObject aluminiumobj;
    public GameObject nickelobj;
    
    
     void Start ()
     {
        metalinoven = false;
        animator = giessform.GetComponent<Animator>();
        
     }
   
void OnTriggerEnter2D (Collider2D collision)
    {
        
         if (collision.transform == titan)
         {
           metalinoven = true;
           metaltype = 1;
           
         }
         
          if (collision.transform == eisen)
         {
           metalinoven = true;
           metaltype = 2;
         }
          if (collision.transform == aluminium)
         {
           metalinoven = true;
           metaltype = 3;
         }
          if (collision.transform == nickel)
         {
           metalinoven = true;
           metaltype = 4;
         }
          if (collision.transform == platin)
         {
           metalinoven = true;
           metaltype = 5;
         }     
     }
     
     void OnTriggerExit2D (Collider2D collision)
    {
        
         if (collision.transform == titan)
         {
           metalinoven = false;
           metaltype = 0;
         }
         
          if (collision.transform == eisen)
         {
           metalinoven = false;
           metaltype = 0;
         }
          if (collision.transform == aluminium)
         {
           metalinoven = false;
           metaltype = 0;
         }
          if (collision.transform == nickel)
         {
           metalinoven = false;
           metaltype = 0;
         }
          if (collision.transform == platin)
         {
           metalinoven = false;
           metaltype = 0;
         }     
     }
     
     void Update()
     {          
            if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 1)
           {
                titanobj.SetActive (false);
                metaltype = 0;
                animator.SetBool("NewKey", false);                 
           }
           
            if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 2)
           {
                eisenobj.SetActive (false);
                metaltype = 0;
                animator.SetBool("NewKey", false);
                
           }
           
           if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 3)
           {
                aluminiumobj.SetActive (false);
                metaltype = 0;
                animator.SetBool("NewKey", false);
                
           }
           if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 4)
           {
                nickelobj.SetActive (false);
                metaltype = 0;
                animator.SetBool("NewKey", false);
                
           }
           if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 5)
           {
                platinobj.SetActive (false);
                metaltype = 5;
                animator.SetBool("NewKey", false);
                
           }
     }
}  