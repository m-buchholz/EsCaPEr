using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ShowTemperatureOfLock : MonoBehaviour
{
    public bool finished;
    public int metaltype;
    public Transform Thermometer;
    public GameObject temperatur;
    public Transform key;
    public GameObject keytype;
    public GameObject ofen; 
    
    public GameObject fox;
    
    
    public GameObject keyspawn; 
    
    
     void Start ()
     {
         finished = false;
         temperatur.SetActive (false);           
     }
     
     void OnTriggerEnter2D (Collider2D collision)
     {
        if (collision.transform == Thermometer)
         {
            temperatur.SetActive (true);
         }
        
         if (collision.transform == key && ofen.GetComponent<CheckMetal>().metaltype <= 4)
         {
            keytype.SetActive (false);     
            Respawn (); 
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 1)
            {
                fox.SetActive(true);
                fox.GetComponentInChildren<Text>().text = "Oh, geschmolzen! Da die Schmelztemperatur von Titan 1668°C beträgt, hält es dem glühenden Schloss nicht stand.";
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 2)
            {
                fox.SetActive(true);
                fox.GetComponentInChildren<Text>().text = "Die Schmelztemperatur von Eisen bertägt 1538°C. Dieses öffnet leider nicht die Tür.";
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 3)
            {
                fox.SetActive(true);
                fox.GetComponentInChildren<Text>().text = "Und geschmolzen! Aluminium hält leider nur 660,3°C aus, bevor es zerfließt.";
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 4)
            {
                fox.SetActive(true);
                fox.GetComponentInChildren<Text>().text = "Das ist Nickel mit einer Schmelztemperatur von 1455°C. Leider hält das dem Schloss nicht stand.";
            }
            
            }     
         
         if (collision.transform == key && ofen.GetComponent<CheckMetal>().metaltype == 5)
         {
            fox.SetActive(true);
            fox.GetComponentInChildren<Text>().text = "Das ist Platin mit einer Schmelztemperatur von 1768°C. Dieser Schlüssel öffnet die Tür! Super!!";
            
            keytype.SetActive (false); 
            Respawn ();
            // set win and get PSE element
            PlayerPrefs.SetInt("Room1_Minigame2", 1);
            PlayerPrefs.SetInt("Elements", (PlayerPrefs.GetInt("Elements") + 1));
            PlayerPrefs.SetString("ElementsInventory", (PlayerPrefs.GetString("ElementsInventory") + "78-Pt,"));
            // open room2
            PlayerPrefs.SetInt("Room2", 1);
            finished = true;
    
        }                           
         
    }
    
    void Update ()
    {
          if (fox.activeSelf == false && finished == true)
            {
                Initiate.Fade("Room1", Color.black, 10f);
            }
    }
    
    void OnTriggerExit2D (Collider2D collision)
    {
        
         if (collision.transform == Thermometer)
         {
            temperatur.SetActive (false);
            
         }       
          
    }   
    void Respawn ()
    {
        keytype.transform.position = keyspawn.transform.position;
          
    }

}
