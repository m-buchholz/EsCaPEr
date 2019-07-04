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

        GameObject.Find("universalindikator").GetComponent<Rigidbody2D>().freezeRotation = true;
        GameObject.Find("raum2_ph_tabelle").GetComponent<Rigidbody2D>().freezeRotation = true;
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