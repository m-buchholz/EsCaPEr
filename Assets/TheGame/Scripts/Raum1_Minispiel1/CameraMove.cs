using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraMove : MonoBehaviour
{

    public GameObject toPosition;

    int i = 0;
    public void MoveCamera()
    {
        GameObject camera = GameObject.Find("Main Camera");


        camera.transform.position = Vector3.Lerp(transform.position, toPosition.transform.position, Time.deltaTime);
    }
   }
