using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    private float alphaLevel;

/// <summary>
/// Change color to green/red if the assignment is true/false
/// </summary>
     public void Fade()
    {


            GameObject overlayBox = gameObject.transform.parent.gameObject.transform.GetChild(0).gameObject;
            overlayBox.transform.position = gameObject.transform.position;
            if (gameObject.GetComponent<CollisionControllerForAssignment>().isCorrect() == true)
            {

                overlayBox.GetComponent<SpriteRenderer>().color = origin;
                overlayBox.transform.position = gameObject.transform.position;
                alphaLevel = 0f;
                ChangeColor(0, 1, 0, alphaLevel, overlayBox);



                FadeOutSymbol(1, overlayBox);
                FadeInSymbol(0, overlayBox);


            }
            else if (gameObject.GetComponent<CollisionControllerForAssignment>().isCorrect() == false && gameObject.GetComponent<CollisionControllerForAssignment>().isAssign() == true)
            {
                Color normal = overlayBox.GetComponent<SpriteRenderer>().color;
                overlayBox.transform.position = gameObject.transform.position;
                ChangeColor(1, 0, 0, alphaLevel, overlayBox);

                FadeOutSymbol(0, overlayBox);
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
    private void FadeInSymbol(int i, GameObject gameObject)
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
    private void FadeOutSymbol(int i, GameObject gameObject)
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
        while (a < 0.5)
        {
            a = a + 0.1f;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(r, g, b, a);
        }
    }

}
