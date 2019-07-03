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
        if (sourceImage != null) showObject.GetComponentInChildren<Image>().sprite = sourceImage;
        if (!showObject.activeSelf) showObject.SetActive(true);
        else showObject.SetActive(false);
    }
}
