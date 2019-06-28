using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;

public class Test : MonoBehaviour
{

    void Start()
    {
        GameObject glass_a = GameObject.Find("glass_h2so4");
        GameObject glass_aa = GameObject.Find("glass_h2so4_tested");
        GameObject glass_b = GameObject.Find("glass_naoh");
        GameObject glass_c = GameObject.Find("glass_hgoh2");
        GameObject glass_d = GameObject.Find("glass_hcl");
        GameObject glass_e = GameObject.Find("glass_khco3");

        GameObject uniInd = GameObject.Find("universalindikator");

        glass_aa.GetComponent<SpriteRenderer>().sortingOrder = 3;

    }    
}