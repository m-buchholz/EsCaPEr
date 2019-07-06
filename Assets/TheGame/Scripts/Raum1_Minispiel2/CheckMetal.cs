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
    
    public GameObject key;
    
    
     void Start ()
     {
        metalinoven = false;
        animator = giessform.GetComponent<Animator>();
     }
   
void OnTriggerEnter2D (Collider2D collision)
    {
        
         if (collision.transform == titan && key.activeSelf == false)
         {
           metalinoven = true;
           metaltype = 1;           
         }
          if (collision.transform == eisen && key.activeSelf == false)
         {
           metalinoven = true;
           metaltype = 2;
         }
          if (collision.transform == aluminium && key.activeSelf == false)
         {
           metalinoven = true;
           metaltype = 3;
         }
          if (collision.transform == nickel && key.activeSelf == false)
         {
           metalinoven = true;
           metaltype = 4;
         }
          if (collision.transform == platin && key.activeSelf == false)
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
         }
         
          if (collision.transform == eisen)
         {
           metalinoven = false;
         }
          if (collision.transform == aluminium)
         {
           metalinoven = false;
         }
          if (collision.transform == nickel)
         {
           metalinoven = false;
         }
          if (collision.transform == platin)
         {
           metalinoven = false;
         }     
     }
     
     void Update()
     {          
             if (key.activeSelf == false && metalinoven == false)
           {
                metaltype = 0;
           }
            
            if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 1)
           {
                titanobj.SetActive (false);
                animator.SetBool("NewKey", false);                 
           }
           
            if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 2)
           {
                eisenobj.SetActive (false);
                animator.SetBool("NewKey", false);
           }
           
           if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 3)
           {
                aluminiumobj.SetActive (false);
                animator.SetBool("NewKey", false);   
           }
           
           if (animator.GetBool("NewKey") && animator.GetBool("MetalInside") && metaltype == 4)
           {
                nickelobj.SetActive (false);
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