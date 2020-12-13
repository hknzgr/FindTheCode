using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitButtonsScript : MonoBehaviour
{
    public InputField Num1, Num2, Num3, Num4;
    public string Number;
    public static int counter;

    public void DigitEnter(string Number)
    {
        if (counter==0)
        {
            Num1.text = Number;
            Num2.text = "";
            Num3.text = "";
            Num4.text = "";

        }
        if (counter == 1)
        {
            Num2.text = Number;
           
        }
        if (counter == 2)
        {
            Num3.text = Number;
           
        }
        if (counter == 3)
        {
            Num4.text = Number;
            
        }
        counter++;
    }

    public void ClearText()
    {
        counter = 0;
        Num1.text = "";
        Num2.text = "";
        Num3.text = "";
        Num4.text = "";
    }

    public void NewCode()
    {
        counter = 0;
        Num1.text = "";
        Num2.text = "";
        Num3.text = "";
        Num4.text = "";
    }
}
