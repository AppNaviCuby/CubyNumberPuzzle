using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberSelecter : MonoBehaviour
{
    //public float displayAlpha = 1.0f;
    //public float hideAlpha = 0.3f;
    //public Image rowOneButton,rowTwoButton,rowThreeButton;
    //private float rowOneRed, rowOneGreen, rowOneBlue, rowTwoRed, rowTwoGreen, rowTwoBlue, rowThreeRed, rowThreeGreen, rowThreeBlue;

    // Start is called before the first frame update
    void Start()
    {
        /*
        rowOneRed = rowOneButton.color.r;
        rowOneGreen = rowOneButton.color.g;
        rowOneBlue = rowOneButton.color.b;

        rowTwoRed = rowTwoButton.color.r;
        rowTwoGreen = rowTwoButton.color.g;
        rowTwoBlue = rowTwoButton.color.b;

        rowThreeRed = rowThreeButton.color.r;
        rowThreeGreen = rowThreeButton.color.g;
        rowThreeBlue = rowThreeButton.color.b;
        ColorReset();
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnKariClick(GameObject thisButton)
    {
        /*
        rowOneButton.color = new Color(rowOneRed, rowOneGreen, rowOneBlue, hideAlpha);
        rowTwoButton.color = new Color(rowTwoRed, rowTwoGreen, rowTwoBlue, hideAlpha);
        rowThreeButton.color = new Color(rowThreeRed, rowThreeGreen, rowThreeBlue, hideAlpha);

        Image thisImage = thisButton.GetComponent<Image>();
        thisImage.color = new Color(thisImage.color.r, thisImage.color.g, thisImage.color.b, displayAlpha);
        */

        //Debug.Log("計算開始")
        Culclator culclator = new Culclator();
        culclator.Culclate(thisButton);
        //Debug.Log("計算終了");
    }

    /*
    public void ColorReset()
    {
        rowOneButton.color = new Color(rowOneRed, rowOneGreen, rowOneBlue, hideAlpha);
        rowTwoButton.color = new Color(rowTwoRed, rowTwoGreen, rowTwoBlue, hideAlpha);
        rowThreeButton.color = new Color(rowThreeRed, rowThreeGreen, rowThreeBlue, hideAlpha);
    }
    */
}