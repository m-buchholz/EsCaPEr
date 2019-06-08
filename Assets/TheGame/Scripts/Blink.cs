using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{

    public Button button;
    private bool isover=false;

    private void OnMouseOver()
    {
        isover = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
