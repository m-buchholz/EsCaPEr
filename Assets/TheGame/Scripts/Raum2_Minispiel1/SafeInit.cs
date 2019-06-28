using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SafeInit : MonoBehaviour
{
    public Boolean locked;
    public int pin;

    private void Start()
    {
        locked = true;
        pin = 211738;
    }
    
    public Boolean getLocked()
    {
        return locked;
    }
    public int getPin()
    {
        return pin;
    }

    public void setLocked(Boolean locked)
    {
        this.locked = locked;
    }
}