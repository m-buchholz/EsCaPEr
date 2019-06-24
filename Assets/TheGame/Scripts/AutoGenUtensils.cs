using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenUtensils : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenerateObj(0, 0, "lol");
    }

    private void GenerateObj(float x, float y, string utensil)
    {
        GameObject gameObject = (GameObject)Instantiate(Resources.Load("Assets/TheGame/Prefabs/Messzylinder"));

    }


}
