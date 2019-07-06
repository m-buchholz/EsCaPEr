using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMetal : MonoBehaviour
{

public GameObject ofen;
public GameObject thismetal;  
public GameObject[] othermetals;
Color thiscolor;

public GameObject key;


void Start ()
    {
            
            othermetals = GameObject.FindGameObjectsWithTag("Metal"); 
                       
    }

void OnMouseDrag()
    {
        if (thismetal.name == "titan")
        {
           if(key.activeSelf == false && ofen.GetComponent<CheckMetal>().metaltype == 0 || ofen.GetComponent<CheckMetal>().metaltype == 1)
            {
                Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
                transform.position = newPosition;   
                ChangeColor ();
            } 
        }
        
         if (thismetal.name == "eisen")
        {
           if(key.activeSelf == false && ofen.GetComponent<CheckMetal>().metaltype == 0 || ofen.GetComponent<CheckMetal>().metaltype == 2)
            {
                Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
                transform.position = newPosition;  
                ChangeColor ();
            }
        }
        
         if (thismetal.name == "aluminium")
        {
           if(key.activeSelf == false && ofen.GetComponent<CheckMetal>().metaltype == 0 || ofen.GetComponent<CheckMetal>().metaltype == 3)
            {
                Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
                transform.position = newPosition;  
                ChangeColor ();
            }
        }
        
         if (thismetal.name == "nickel")
        {
           if(key.activeSelf == false && ofen.GetComponent<CheckMetal>().metaltype == 0 || ofen.GetComponent<CheckMetal>().metaltype == 4)
            {
                Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
                transform.position = newPosition; 
                ChangeColor ();
            }
        }
        
         if (thismetal.name == "platin")
        {
           if(key.activeSelf == false && ofen.GetComponent<CheckMetal>().metaltype == 0 || ofen.GetComponent<CheckMetal>().metaltype == 5)
            {
                Vector2 mousPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 newPosition = Camera.main.ScreenToWorldPoint(mousPosition);
                transform.position = newPosition; 
                ChangeColor ();
            }
        }
    }

  
void Update()
{
     foreach (GameObject metal in othermetals)
    {
        if (key.activeSelf == false && ofen.GetComponent<CheckMetal>().metaltype == 0)
        {
            metal.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        } 
        
    } 
}




void ChangeColor ()
{
    foreach (GameObject metal in othermetals)
    { 
        if (metal.name != thismetal.name)
        {
            metal.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.35f);
        }   
    }
   
}       
}
