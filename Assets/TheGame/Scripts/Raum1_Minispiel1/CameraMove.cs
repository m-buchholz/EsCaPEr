using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraMove : MonoBehaviour
{

    public GameObject toPosition;
    public bool check = false;

    public void StartMoving()
    {
        check = true;
    }
    public void Update()
    {
        GameObject camera = GameObject.Find("Main Camera");


        if(check == true){
            camera.transform.position = Vector3.Lerp(camera.transform.position, toPosition.transform.position, Time.deltaTime);
        }


            
    }
   }
