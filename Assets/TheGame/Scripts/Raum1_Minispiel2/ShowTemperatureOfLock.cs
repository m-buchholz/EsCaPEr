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
                fox.GetComponentInChildren<Text>().text = "Oh, dein Schlüssel ist geschmolzen! Titan ist für so hohe Temperaturen scheinbar nicht geeignet! Schau doch nochmal ins Foyer, dort war eine kleine Notiz zu den Metallen.";
                fox.SetActive(true);
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 2)
            {
                fox.GetComponentInChildren<Text>().text = "Oh, dein Schlüssel ist geschmolzen! Eisen ist für so hohe Temperaturen scheinbar nicht geeignet!";
                fox.SetActive(true);
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 3)
            {
                fox.GetComponentInChildren<Text>().text = "Oh, dein Schlüssel ist geschmolzen! Aluminium ist für so hohe Temperaturen scheinbar nicht geeignet! Schau doch nochmal ins Foyer, dort war eine kleine Notiz zu den Metallen.";
                fox.SetActive(true);
            }
            
            if (ofen.GetComponent<CheckMetal>().metaltype == 4)
            {
                fox.GetComponentInChildren<Text>().text = "Oh, dein Schlüssel ist geschmolzen! Nickel ist für so hohe Temperaturen scheinbar nicht geeignet!";
                fox.SetActive(true);
            }
            
            }     
         
         if (collision.transform == key && ofen.GetComponent<CheckMetal>().metaltype == 5)
         {
            fox.GetComponentInChildren<Text>().text = "Wow, dein Schlüssel aus Platin hält der Hitze stand. Lass uns die Tür öffnen!";
            fox.SetActive(true);

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
