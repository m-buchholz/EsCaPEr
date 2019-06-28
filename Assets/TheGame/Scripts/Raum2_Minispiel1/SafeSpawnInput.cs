using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SafeSpawnInput : MonoBehaviour
{
    private Button button;

    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SpawnSafeInput);
    }

    // Update is called once per frame
    public void SpawnSafeInput()
    {
        GameObject safeInput = GameObject.Find("InputField");
        GameObject safeSubmit = GameObject.Find("raum2_tresor_submit");

        if (safeInput.transform.localScale.x == 0)
        {
            safeInput.transform.localScale = new Vector3(1, 1, 1);
            safeSubmit.transform.localScale = new Vector3(12.8f, 12.8f, 12.8f);
        }
        else
        {
            safeInput.transform.localScale = new Vector3(0, 0, 0);
            safeSubmit.transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
