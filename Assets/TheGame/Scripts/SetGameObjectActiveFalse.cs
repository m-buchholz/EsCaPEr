using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetGameObjectActiveFalse : MonoBehaviour
{
    private Button button;
    public GameObject obj;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(hideObj);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump")) hideObj(); 
    }

    private void hideObj()
    {
        obj.SetActive(false);
    }
}
