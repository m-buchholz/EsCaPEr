using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Show an image as overlay
/// </summary>

public class ShowObject : MonoBehaviour
{
    public GameObject showObject;
    public Sprite sourceImage;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(show);
    }

    private void show()
    {
        showObject.GetComponentInChildren<Image>().sprite = sourceImage;
        showObject.SetActive(true);
    }
}
