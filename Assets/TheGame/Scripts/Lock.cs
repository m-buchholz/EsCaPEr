using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Lock : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPressed;
    private Button keyLock;
    public GameObject overlay;

    void Start()
    {
        keyLock = GetComponent<Button>();
        if (PlayerPrefs.GetInt("Room2") == 1)
        {
            keyLock.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (isPressed)
        {
            overlay.SetActive(true);
        }
        else overlay.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}