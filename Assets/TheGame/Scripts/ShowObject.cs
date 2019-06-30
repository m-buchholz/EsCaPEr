using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowObject : MonoBehaviour
{
    public GameObject showObject;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(show);
    }

    private void show()
    {
        showObject.SetActive(true);
    }
}
