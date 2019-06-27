using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class namePos : MonoBehaviour
{
    public Text nameLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 namep = Camera.main.WorldToScreenPoint(this.transform.position);
        nameLabel.transform.position = namep;
    }
}
