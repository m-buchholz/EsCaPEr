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
                fox.GetComponentInChildren<Text>().text = "Oh, geschmolzen! Da die Schmelztemperatur von Titan 1668�C betr�gt, h�lt es dem gl�henden Schloss nicht stand.";
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 2)
            {
                fox.SetActive(true);
                fox.GetComponentInChildren<Text>().text = "Die Schmelztemperatur von Eisen bert�gt 1538�C. Dieses �ffnet leider nicht die T�r.";
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 3)
            {
                fox.SetActive(true);
                fox.GetComponentInChildren<Text>().text = "Und geschmolzen! Aluminium h�lt leider nur 660,3�C aus, bevor es zerflie�t.";
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 4)
            {
                fox.SetActive(true);
                fox.GetComponentInChildren<Text>().text = "Das ist Nickel mit einer Schmelztemperatur von 1455�C. Leider h�lt das dem Schloss nicht stand.";
            }
            
            }     
         
         if (collision.transform == key && ofen.GetComponent<CheckMetal>().metaltype == 5)
         {
            fox.SetActive(true);
            fox.GetComponentInChildren<Text>().text = "Das ist Platin mit einer Schmelztemperatur von 1768�C. Dieser Schl�ssel �ffnet die T�r! Super!!";
            
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
