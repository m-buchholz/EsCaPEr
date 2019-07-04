using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour
{
    public Text nameLabel;
    public float speed;
    public Text countText;
    public Text WinText;
    public Button moveUp, moveDown;
    Rigidbody2D rb;
    private int count;
    private float moveb;

    //player movements
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        moveb = 0f;
        moveUp.onClick.AddListener(moveU);
        moveDown.onClick.AddListener(moveD);
        //count = 0;
        //WinText.text = "";
        //setCountText();
    }

    private void moveU() { moveb = 1f; }
    private void moveD() { moveb = -1f; }

    // Update is called once per frame
    void Update()
    {
       // float moveh = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");

        // invisible button control (touch)
        if (moveb != 0f)
        {
            if (moveb > 0f)
            {
                if (moveb <= 0.1) moveb = 0;
                else moveb += -0.02f;
            }
            else
            {
                if (moveb >= -0.1) moveb = 0;
                else moveb += 0.02f;
            }
            movev = moveb;
        }

       // rb.velocity = new Vector2(speed * moveh, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, speed * movev);
    }


    //Destroy molecules on contact
    /* void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.CompareTag("molecule"))
         {
             Destroy(other.gameObject);
             //other.gameObject.SetActive(false);
             count += 1;
            // setCountText();
         }

     }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(nameLabel);
}


    //counts molecules
    /*void setCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 2)
        {
            WinText.text = "Well Done!";
        }
    }*/

}
