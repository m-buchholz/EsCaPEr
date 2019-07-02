using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckMetal : MonoBehaviour
{
    public bool metalinoven;
    public int metaltype;
   
    public Transform titan;
    public Transform platin;
    public Transform eisen;
    public Transform aluminium;
    public Transform nickel;
    
     void Start ()
     {
        metalinoven = false;
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
          if (collision.transform == titan)
         {
           metalinoven = aluminium;
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
}