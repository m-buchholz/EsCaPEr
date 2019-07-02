using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowTemperatureOfLock : MonoBehaviour
{
    public int metaltype;
    public Transform Thermometer;
    public GameObject temperatur;
    public Transform key;
    public GameObject keytype;
    public GameObject ofen; 
    
    public GameObject keyspawn; 
    
    
     void Start ()
     {
         temperatur.SetActive (false);
         
     }
   
void OnTriggerEnter2D (Collider2D collision)
    {
        
         if (collision.transform == Thermometer)
         {
            temperatur.SetActive (true);
         }
         if (collision.transform == key && ofen.GetComponent<CheckMetal>().metaltype == 1)
         {
            temperatur.SetActive (true);
            keytype.SetActive (false); 
            
            Respawn();  
         }                             
         
    }
    void OnTriggerExit2D (Collider2D collision)
    {
        
         if (collision.transform == Thermometer)
         {
            temperatur.SetActive (false);
         }
         if (collision.transform == key && ofen.GetComponent<CheckMetal>().metaltype == 1)
         {
            temperatur.SetActive (false);
            keytype.SetActive (false);   
         }                            
         }   

         
         void Respawn ()
         {
         keytype.transform.position =  keyspawn.transform.position;
         }
}
