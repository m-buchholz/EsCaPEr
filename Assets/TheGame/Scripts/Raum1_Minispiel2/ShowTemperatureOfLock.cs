using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowTemperatureOfLock : MonoBehaviour
{
    public Transform Thermometer;
    public GameObject temperatur;
    
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
         
    }
    void OnTriggerExit2D (Collider2D collision)
    {
        
         if (collision.transform == Thermometer)
         {
            temperatur.SetActive (false);
         }
    
}   }