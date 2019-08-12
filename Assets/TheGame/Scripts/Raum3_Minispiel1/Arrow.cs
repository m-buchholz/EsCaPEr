using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject arrowUp;
    public GameObject arrowDown;

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);

        Destroy(arrowDown);
        Destroy(arrowUp);

    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Destroy(arrowDown);
            Destroy(arrowUp);
        }
    }
}
