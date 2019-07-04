using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SafeSubmit : MonoBehaviour
{
    private Button button;

    SafeInit theSafe;

    private InputField safeInput;
    private GameObject safeDoor;
    private GameObject safeSubmit;

    private int pin;
    private Boolean locked;
    
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SubmitSafeInput);

        theSafe = GameObject.Find("ButtonCanvas").GetComponent<SafeInit>();

        safeInput = GameObject.Find("InputField").GetComponent<InputField>();
        safeDoor = GameObject.Find("raum2_tresor");
        safeSubmit = GameObject.Find("raum2_tresor_submit");
        
        pin = theSafe.getPin();
        locked = theSafe.getLocked();
    }

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
            if(locked)
                SubmitSafeInput();
    }

    void SubmitSafeInput()
    {
        int input = Int32.Parse(safeInput.text);

        Debug.Log(input);
        Debug.Log(pin);
        Debug.Log(locked);

        if (input == pin & locked == true)
        {
            OpenSafeDoor();
            locked = false;
        }
    }

    void OpenSafeDoor()
    {
        if(locked)
        { 
            safeDoor.transform.localPosition += new Vector3(-424, 0, 0);
            safeInput.transform.localScale = new Vector3(0, 0, 0);
            safeSubmit.transform.localScale = new Vector3(0, 0, 0);
        }

        theSafe.setLocked(false);

        safeDoor.GetComponent<Button>().onClick.RemoveListener(safeDoor.GetComponent<SafeSpawnInput>().SpawnSafeInput);
        safeDoor.GetComponent<Button>().onClick.AddListener(ShutSafeDoor);
    }

    void ShutSafeDoor()
    {
        safeDoor.transform.localPosition += new Vector3(424, 0, 0);

        safeDoor.GetComponent<Button>().onClick.RemoveListener(ShutSafeDoor);
        safeDoor.GetComponent<Button>().onClick.AddListener(safeDoor.GetComponent<SafeSpawnInput>().SpawnSafeInput);

        theSafe.setLocked(true);
    }
}
