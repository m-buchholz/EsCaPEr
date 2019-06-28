using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControllerForGlasses : MonoBehaviour
{
    public GameObject glass_h2so4;
    public GameObject glass_naoh;
    public GameObject glass_hgoh2;
    public GameObject glass_hcl;
    public GameObject glass_khco3;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == glass_h2so4)
        {
            glass_h2so4.SetActive(false);
        }

        if (collision.gameObject == glass_naoh)
        {
            glass_naoh.SetActive(false);
        }

        if (collision.gameObject == glass_hgoh2)
        {
            glass_hgoh2.SetActive(false);
        }

        if (collision.gameObject == glass_hcl)
        {
            glass_hcl.SetActive(false);
        }

        if (collision.gameObject == glass_khco3)
        {
            glass_khco3.SetActive(false);
        }
    }
}
