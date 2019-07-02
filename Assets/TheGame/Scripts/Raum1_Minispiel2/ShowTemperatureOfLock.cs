using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowTemperatureOfLock : MonoBehaviour
{
    public int metaltype;
    public Transform Thermometer;
    public GameObject temperatur;
    public Transform key;
    public GameObject keytype;
    public GameObject ofen; 
    public GameObject over;
    
    
    public GameObject keyspawn; 
    
    
     void Start ()
     {
         temperatur.SetActive (false);
         over.SetActive (false);
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
            over.SetActive (true);    
            Respawn ();   
         }     
         
         if (collision.transform == key && ofen.GetComponent<CheckMetal>().metaltype == 5)
         {
            keytype.SetActive (false);
            over.SetActive (false); 
            Respawn ();
            // set win and get PSE element
            PlayerPrefs.SetInt("Room1_Minigame2", 1);
            PlayerPrefs.SetInt("Elements", (PlayerPrefs.GetInt("Elements") + 1));
            PlayerPrefs.SetString("ElementsInventory", (PlayerPrefs.GetString("ElementsInventory") + "78-Pt,"));
            // open room2
            PlayerPrefs.SetInt("Room2", 1);

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
