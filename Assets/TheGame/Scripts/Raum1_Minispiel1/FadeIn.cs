using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    private float alphaLevel;
    private Color origin;

/// <summary>
/// Change color to green/red if the assignment is true/false
/// </summary>
     public void Fade()
    {
            

            GameObject overlayBox = gameObject.transform.parent.gameObject;
        GameObject check = overlayBox.transform.GetChild(2).gameObject;
        GameObject cross = overlayBox.transform.GetChild(1).gameObject;
            if (gameObject.GetComponent<CollisionControllerForAssignment>().isCorrect() == true)
            {

                gameObject.GetComponent<SpriteRenderer>().color = origin;
                check.transform.position = gameObject.transform.position;
                alphaLevel = 0f;
                ChangeColor(0, 1, 0, alphaLevel, gameObject);



                FadeOutSymbol(1, overlayBox);
                FadeInSymbol(2, overlayBox);


            }
            else if (gameObject.GetComponent<CollisionControllerForAssignment>().isCorrect() == false && gameObject.GetComponent<CollisionControllerForAssignment>().isAssign() == true)
            {
                Color normal = gameObject.GetComponent<SpriteRenderer>().color;
                cross.transform.position = gameObject.transform.position;
                ChangeColor(1, 0, 0, alphaLevel, gameObject);

                FadeOutSymbol(2, overlayBox);
                FadeInSymbol(1, overlayBox);

            }
            else
            {
                overlayBox.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
                //FadeOutSymbol(0, overlayBox);
                //FadeOutSymbol(1, overlayBox);
            }

    }

    /// <summary>
    /// Set the transparency of child "i" from the GameObject "gameObject" to 100%
    /// </summary>
    /// <param name="i"></param>
    /// <param name="gameObject"></param>
    public void FadeInSymbol(int i, GameObject gameObject)
    {
        gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color = new Color(gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color.r,
            gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color.g,
            gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color.b, 1f);
    }

    /// <summary>
    /// Set the transparency of child "i" from the GameObject "gameObject" to 0%
    /// </summary>
    /// <param name="i"></param>
    /// <param name="gameObject"></param>
    public void FadeOutSymbol(int i, GameObject gameObject)
    {
        gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color = new Color(gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color.r,
            gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color.g,
            gameObject.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().color.b, 0f);
    }

    /// <summary>
    /// Set the color of the GameObject "gameObject" to the given color rgb... "a" is for the transparency
    /// </summary>
    /// <param name="r"></param>
    /// <param name="g"></param>
    /// <param name="b"></param>
    /// <param name="a"></param>
    /// <param name="gameObject"></param>
    private void ChangeColor(float r, float g, float b, float a, GameObject gameObject)
    {
        while (a < 1)
        {
            a = a + 0.1f;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(r, g, b, a);
        }
    }

}
